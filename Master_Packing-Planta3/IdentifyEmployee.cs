using System;
using System.Linq;
using System.Windows.Forms;

namespace Master_Packing
{
    public partial class IdentifyEmployee : Form
    {
        User operador = new User();
        WorkOrder orden = new WorkOrder();
        Conexion con = new Conexion();
        public IdentifyEmployee()
        {
            InitializeComponent();
        }
        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void txt_empleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_aceptar_Click(this, new EventArgs());
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                operador.idemp = Convert.ToInt32(txt_empleado.Text.Trim());
                if (txt_empleado.Text == "")
                    throw new Exception();

                int regreso = int.Parse(operador.ReturnValue("select id_user from tb_User where nemploy = " + txt_empleado.Text));

                if (regreso > 0)
                {
                    operador.Id_user = regreso;
                    //orden.Crud("update tb_Orden set id_user = " + regreso + " where orden = " + orden.wo);
                    Scannig ee = new Scannig();
                    //ee.Show();

                    Form enet;

                    if ((enet = IsFormAlreadyOpen(typeof(Scannig))) == null)
                    {
                        ee.ShowDialog(this);
                        this.Close();
                    }

                    else
                    {
                        enet.WindowState = FormWindowState.Normal;
                        enet.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro");
                    txt_empleado.Text = "";
                }

                con.Cerrar();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existe ese registro", "ERROR!");
                con.Cerrar();
            }
            catch (Exception)
            {
                MessageBox.Show("Insert an Id!");
            }
        }
    }
}
