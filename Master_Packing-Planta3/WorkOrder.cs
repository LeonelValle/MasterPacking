using System;
using System.Data.SqlClient;

namespace Master_Packing
{
    class WorkOrder : Conexion
    {
        static int id_wo;
        public string wo { get; set; }
        public int qty { get; set; }
        public string rev { get; set; }
        public DateTime datecreated { get; set; }
        public int ubox { get; set; }
        public int id_pn { get; set; }
        public int id_user { get; set; }
        public int id_box { get; set; }
        public int Id_wo { get => id_wo; set => id_wo = value; }

        private SqlConnection Conex; // Obj Conexion

        public WorkOrder() =>
        //Conex = new SqlConnection(@"Data Source=192.168.4.5\MSSQLDB;Initial Catalog=master;User ID=sa;Password=Password01;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        Conex = new SqlConnection(@"Data Source=192.168.4.5\MSSQLDB;Initial Catalog=master;User ID=sa;Password=Password01;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private SqlConnection Con { get => Conex; set => Conex = value; }


        /// <summary>
        /// Metodo para abrir la conexion con la base de datos
        /// </summary>
        public new void Abrir() // Metodo para Abrir la Conexion
        {
            Conex.Open();
        }

        /// <summary>
        /// Metodo para cerrar la conexion con la base de datos
        /// </summary>
        public new void Cerrar() // Metodo para Cerrar la Conexion
        {
            Conex.Close();
        }

        public string ReturnFromROI(string comando)
        {
            string valor;
            try
            {
                using (SqlCommand CMD = new SqlCommand(comando, Conex))
                {
                    this.Abrir();
                    //CMD.ExecuteNonQuery();
                    valor = CMD.ExecuteScalar().ToString();
                }
                if (valor == "")
                    valor = "0";
            }
            catch (Exception)
            {
                valor = "0";
            }
            this.Cerrar();
            return valor;
        }
    }
}
