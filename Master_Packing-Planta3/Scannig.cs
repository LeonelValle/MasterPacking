using Seagull.BarTender.Print;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Master_Packing
{
    public partial class Scannig : Form
    {
        WorkOrder wo = new WorkOrder();
        User user = new User();
        PN pn = new PN();
        Scan sc = new Scan();
        Box box = new Box();

        public Scannig()
        {
            InitializeComponent();
        }



        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //CheckSerial();



            if (!String.IsNullOrEmpty(txt_Scan.Text.Trim()))
            {
                if (txt_Scan.Text.Trim().Length == 18)
                {

                    if (!sc.Existe("select count(*) from tb_Scan where SN = '" + txt_Scan.Text.Trim() + "'"))
                    {

                        sc.Crud("insert into tb_Scan (SN, dateScan, id_wo, id_box) values('" + txt_Scan.Text.Trim() + "','" + DateTime.Now + "','" + wo.Id_wo + "','" + box.Id_box + "')");
                        txt_Scan.Text = "";
                        txt_Scan.Focus();
                        PackingBox();
                        Scannig_Load(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("Serial Already exist!");
                    }
                }
                else
                {
                    MessageBox.Show("Check Label!");

                }

            }
        }

        private void Scannig_Load(object sender, EventArgs e)
        {

            wo.wo = wo.ReturnValue("select wo from tb_WO where id_wo = '" + wo.Id_wo + "'");
            user.idemp = int.Parse(user.ReturnID("select nemploy from tb_User where id_user = '" + user.Id_user + "'"));
            pn.pn = pn.ReturnValue("select PN.pn from tb_WO wo join PN on wo.id_pn = PN.id_pn where wo.id_wo = " + wo.Id_wo);
            wo.ubox = int.Parse(wo.ReturnValue("select UnitsBox from tb_WO where id_wo = '" + wo.Id_wo + "'"));
            box.Id_box = int.Parse(box.ReturnID("select id_box from tb_WO where id_wo =  '" + wo.Id_wo + "'"));
            box.Boxes = box.ReturnValue("select box from tb_Box where id_box = " + box.Id_box);

            wo.qty = int.Parse(wo.ReturnValue("select qty from tb_WO where id_wo = '" + wo.Id_wo + "'"));
            sc.top = int.Parse(sc.ReturnValue("select count(*) from tb_Scan where id_wo = '" + wo.Id_wo + "'"));

            if (box.Id_box == 0)
            {
                PackingBox();
            }
            //wo.rev = wo.ReturnValue("select rev from tb_WO where id_wo = '" + wo.Id_wo + "'");

            wo.rev = wo.ReturnFromROI("SELECT * FROM OPENQUERY([M2K81], 'select Bom_Rev_Level from WO_v_1 where Wo_Nbr = ''" + wo.wo + "''')");
            wo.Crud("update tb_WO set rev = '" + wo.rev + "' where id_wo = '" + wo.Id_wo + "'");
            lbl_TotalBox.Text = box.ReturnValue("select count(*) from tb_Scan where id_box = '" + box.Id_box + "'");
            lbl_Emp.Text = user.idemp.ToString();
            lbl_PN.Text = pn.pn;
            lbl_Rev.Text = wo.rev;
            lbl_WO.Text = wo.wo;
            lbl_actualBox.Text = box.Boxes;

            lbl_CountRecords.Text = sc.ReturnValue("select count(*) from tb_Scan where id_wo = '" + wo.Id_wo + "'");
            gv_Scan.DataSource = sc.LlenarDG("select sc.SN as 'Scan', sc.dateScan as 'Date Scan', wo.wo , box.box from tb_Scan sc join tb_WO wo on wo.id_wo = sc.id_wo join tb_Box box on box.id_box = sc.id_box where wo.id_wo = " + wo.Id_wo).Tables[0];

            if (sc.top >= wo.qty)
            {

                txt_Scan.Enabled = false;
                btn_Submit.Enabled = false;
                gv_Scan.Enabled = false;

                MessageBox.Show("WO Completed!");

            }

        }

        private void PackingBox()
        {

            box.Id_box = int.Parse(box.ReturnID("select id_box from tb_WO where id_wo =  '" + wo.Id_wo + "'"));
            box.Count = int.Parse(box.ReturnID("select count(*) from tb_Scan where id_box = '" + box.Id_box + "'"));
            lbl_TotalBox.Text = box.Count.ToString();

            if (box.Id_box == 0)
            {
                box.Boxes = box.ReturnValue("select consecutive from tb_WO where id_wo = '" + wo.Id_wo + "'");
                box.Boxes = (int.Parse(box.Boxes) + 1).ToString();
                box.Crud("update tb_WO set consecutive = '" + box.Boxes + "' where id_wo = '" + wo.Id_wo + "'");
                box.Boxes = box.ReturnValue("select consecutive from tb_WO where id_wo = '" + wo.Id_wo + "'");
                box.Id_box = int.Parse(box.ReturnID("insert into tb_Box values ('" + box.Boxes + "'); SELECT SCOPE_IDENTITY();"));
                wo.Crud("update tb_WO set id_box = '" + box.Id_box + "' where id_wo = " + wo.Id_wo);
                box.Parcial = false;
            }
            else if (box.Count == wo.ubox || box.Parcial == true)
            {

                //PrintBox();
                this.btn_Submit.Enabled = false;

                try
                {
                    Thread threadInput = new Thread(DisplayData);
                    threadInput.Start();

                    //SerialNumber_Load(sender, e);
                    //txt_Qty.Text = "";
                }
                catch (Exception ex)
                {

                    DisplayError(ex);
                }


            }
        }

        private void PrintBox()
        {
            if (pn.pn == "WA000057")
                pn.pn = "IQ30-A";

            if (pn.pn == "WA000059")
                pn.pn = "IQ30-RS";


            using (Engine engine = new Engine())
            {
                engine.Start();
                LabelFormatDocument format = engine.Documents.Open(@"\\mex-fss-001\labels$\Packing\Master-Packing_Planta3.btw");


                //format.PrintSetup.PrinterName = @"Microsoft Print to PDF";
                format.PrintSetup.PrinterName = @"Wasp WPL-305";


                // int Toprint = int.Parse(txt_Qty.Text);
                format.PrintSetup.NumberOfSerializedLabels = 1;
                format.SubStrings["Modelo"].Value = pn.pn;
                format.SubStrings["Cantidad"].Value = box.Count.ToString();
                format.SubStrings["Orden"].Value = wo.wo;
                format.SubStrings["Rev"].Value = wo.rev;
                format.SubStrings["box"].Value = box.Boxes;
                format.SubStrings["Fecha"].Value = DateTime.Today.ToString("MM-dd-yyyy");

                format.Print();

                engine.Stop();

            }
            btn_Submit.Invoke((Action)delegate
            {
                btn_Submit.Enabled = true;
            });
        }

        private void btn_PrintParcial_Click(object sender, EventArgs e)
        {

            //sc.Crud("insert into tb_Scan (SN, dateScan, id_wo, id_box) values('" + txt_Scan.Text.Trim() + "','" + DateTime.Now + "','" + wo.Id_wo + "','" + box.Id_box + "')");
            //txt_Scan.Text = "";
            //txt_Scan.Focus();
            box.Parcial = true;
            PackingBox();
            Scannig_Load(sender, e);

        }

        private bool CheckSerial()
        {
            bool isValid = true;

            string[] SN = txt_Scan.Text.Trim().Split('-');

            pn.pn = SN[0];
            wo.rev = SN[1];
            wo.wo = SN[2];
            sc.SN = SN[3];

            if (pn.pn != lbl_PN.Text)
                isValid = false;
            else if (wo.wo != lbl_WO.Text)
                isValid = false;
            else if (wo.rev != lbl_Rev.Text)
                isValid = false;
            //else if (!sc.Existe("select count(*) from tb_Scan where SN = '" + txt_Scan.Text.Trim() + "'"))
            //    isValid = false;

            return isValid;

        }

        private void DisplayData()
        {
            SetLoading(true);

            // Added to see the indicator (not required)
            //Thread.Sleep(4000);

            //box.Boxes = box.ReturnValue("select box.box from tb_WO wo join tb_box box on wo.id_box = box.id_box where id_wo = "+wo.Id_wo);
            PrintBox();

            box.Boxes = box.ReturnValue("select consecutive from tb_WO where id_wo = '" + wo.Id_wo + "'");
            box.Boxes = (int.Parse(box.Boxes) + 1).ToString();
            box.Crud("update tb_WO set consecutive = '" + box.Boxes + "' where id_wo = '" + wo.Id_wo + "'");
            box.Boxes = box.ReturnValue("select consecutive from tb_WO where id_wo = '" + wo.Id_wo + "'");
            box.Id_box = int.Parse(box.ReturnID("insert into tb_Box values ('" + box.Boxes + "'); SELECT SCOPE_IDENTITY();"));
            wo.Crud("update tb_WO set id_box = '" + box.Id_box + "' where id_wo = " + wo.Id_wo);
            box.Parcial = false;

            SetLoading(false);
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = true;
                    this.Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = false;
                    this.Cursor = Cursors.Default;
                });
            }
        }

        private void DisplayError(Exception ex)
        {
            MessageBox.Show("The below error occurred while processing the request: \n\r \n\r" + ex.Message);
        }

        private void btn_Submit_Enter(object sender, EventArgs e)

        {
            SendKeys.Send("{ENTER}");
        }
    }
}
