using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Master_Packing
{
    public partial class MainMenu : Form
    {
        Conexion con = new Conexion();
        public MainMenu()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InitWO iwo = new InitWO();

            iwo.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreateWO no = new CreateWO();


            no.Show();
            //this.Hide();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Reports re = new Reports();
            re.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            dg_WO.DataSource = con.LlenarDG("select wo, rev, qty, pn from tb_WO wo join PN pn on pn.id_pn = wo.id_pn ").Tables[0];
        }
    }
}
