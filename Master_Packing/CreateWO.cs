using System;
using System.Windows.Forms;

namespace Master_Packing
{
    public partial class CreateWO : Form
    {
        WorkOrder wo = new WorkOrder();
        PN pn = new PN();

        public CreateWO()
        {
            InitializeComponent();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            txt_QTY.Text = wo.ReturnFromROI("SELECT * FROM OPENQUERY([M2K81], 'select Qty_To_Mfg from WO_v_1 where Wo_Nbr = ''" + txt_WO.Text + "''')");
            txt_Rev.Text = wo.ReturnFromROI("SELECT * FROM OPENQUERY([M2K81], 'select Bom_Rev_Level from WO_v_1 where Wo_Nbr = ''" + txt_WO.Text + "''')");
            pn.pn = wo.ReturnFromROI("SELECT left(Part_Nbr,len(Part_Nbr)-3) FROM OPENQUERY([M2K81], 'select Part_Nbr from WO_v_1 where Wo_Nbr = ''" + txt_WO.Text + "''')");
            pn.pnDesc = wo.ReturnFromROI("SELECT * FROM OPENQUERY([M2K81], 'select Part_Description from WO_v_1 where Wo_Nbr = ''" + txt_WO.Text + "''')");

            if (!pn.Existe("select count(*) from PN where pn = '" + pn.pn + "'"))
                pn.Crud("insert into PN values('" + pn.pn + "','" + pn.pnDesc + "')");

            CreateWO_Load(sender, e);
            cb_PN.Text = pn.pn;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (cb_PN.SelectedValue != null || !string.IsNullOrEmpty(txt_QTY.Text.Trim()) || !string.IsNullOrEmpty(txt_Rev.Text.Trim()) || !string.IsNullOrEmpty(txt_UnitsBox.Text.Trim()) || !string.IsNullOrEmpty(txt_WO.Text.Trim()))
            {
                if (!wo.Existe("select count(*) from tb_WO where wo = '" + txt_WO.Text.Trim() + "'"))
                {
                    wo.Crud("insert into tb_WO(wo,qty,rev,dateReg,UnitsBox,id_pn) values('" + txt_WO.Text + "','" + txt_QTY.Text + "','" + txt_Rev.Text + "','" + DateTime.Now + "','" + txt_UnitsBox.Text + "','" + cb_PN.SelectedValue + "')");
                    txt_QTY.Text = "";
                    txt_Rev.Text = "";
                    txt_WO.Text = "";
                    txt_UnitsBox.Text = "";
                    cb_PN.SelectedValue = -1;


                    MessageBox.Show("WO Saved!");

                }
                else
                {
                    MessageBox.Show("Already Exist!");
                }
            }
            else
            {
                MessageBox.Show("Empty fields!");
            }

        }


        private void CreateWO_Load(object sender, EventArgs e)
        {
            cb_PN.DataSource = pn.LlenarComboBox("select id_pn, pn from PN");
            cb_PN.DisplayMember = "pn";
            cb_PN.ValueMember = "id_pn";
            cb_PN.SelectedValue = -1;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_QTY.Text = "";
            txt_Rev.Text = "";
            txt_WO.Text = "";
            txt_UnitsBox.Text = "";
            cb_PN.SelectedValue = -1;
        }
    }
}
