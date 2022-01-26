using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Packing
{
    public partial class InitWO : Form
    {
        WorkOrder wo = new WorkOrder();
        public InitWO()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void InitWO_Load(object sender, EventArgs e)
        {

        }

        private void txt_WO_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_Submit_Click(this, new EventArgs());
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (wo.Existe("select count(*) from tb_WO where wo = '" + txt_WO.Text + "'"))
            {
                //wo.wo = txt_WO.Text;

                wo.Id_wo = int.Parse(wo.ReturnID("select id_wo from tb_WO where wo = '" + txt_WO.Text + "'"));
                //user.Nemploy = int.Parse(txt_Employ.Text);

                IdentifyEmployee sn = new IdentifyEmployee();

                Form NuevaOrden;
                if ((NuevaOrden = IsFormAlreadyOpen(typeof(IdentifyEmployee))) == null)
                {
                    sn.ShowDialog(this);
                }
                else
                {
                    NuevaOrden.WindowState = FormWindowState.Normal;
                    NuevaOrden.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Not found!", "ERROR");
            }
        }
    }
}
