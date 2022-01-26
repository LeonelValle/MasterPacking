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
    public partial class Reports : Form
    {
        WorkOrder wo = new WorkOrder();
        public Reports()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string salida_datos = "";
            _ = this.txt_Search.Text.Split(' ');

            if (cb_filter.Text == "Serial Number")
            {
                if (wo.Existe("select COUNT(*) from tb_Scan where sn = '" + txt_Search.Text + "'"))
                {
                    int id_modelorden = int.Parse(wo.ReturnID("select id_scan from tb_Scan where sn = '" + txt_Search.Text + "'"));
                    salida_datos = "select wo, sn, sc.dateScan, pn, wo.rev, usr.nemploy from tb_Scan sc join tb_WO wo on sc.id_wo = wo.id_wo join PN pn on wo.id_pn = pn.id_pn join tb_User usr on sc.id_user = usr.id_user where sc.id_scan = '" + id_modelorden + "' order by sc.id_scan asc";
                }

            }

            if (cb_filter.Text == "Work Order")
            {
                int id_orden = int.Parse(wo.ReturnValue("select id_wo from tb_WO where wo = " + txt_Search.Text));
                salida_datos = "select wo, sn, sc.dateScan, pn, wo.rev, usr.nemploy from tb_Scan sc join tb_WO wo on sc.id_wo = wo.id_wo join PN pn on wo.id_pn = pn.id_pn join tb_User usr on sc.id_user = usr.id_user where wo.id_wo = " + id_orden + " order by sc.id_scan asc";
            }


            if (cb_filter.Text == "Part NO#")
            {

                salida_datos = "select wo, sn, sc.dateScan, pn, wo.rev, usr.nemploy from tb_Scan sc join tb_WO wo on sc.id_wo = wo.id_wo join PN pn on wo.id_pn = pn.id_pn join tb_User usr on sc.id_user = usr.id_user where pn.pn = '" + txt_Search.Text + "' order by sc.id_scan asc";
            }

            if (cb_filter.Text == "Date Packing")
            {
                DateTime fecha = Convert.ToDateTime(txt_Search.Text);
                string buscar = fecha.ToString("yyyy-MM-dd");
                salida_datos = "select wo, sn, sc.dateScan, pn, wo.rev, usr.nemploy from tb_Scan sc join tb_WO wo on sc.id_wo = wo.id_wo join PN pn on wo.id_pn = pn.id_pn join tb_User usr on sc.id_user = usr.id_user where CONVERT(varchar(255),sc.dateScan,126) LIKE '%" + buscar + "%' order by sc.id_scan asc";
            }


            dg_Report.DataSource = wo.LlenarDG(salida_datos).Tables[0];

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            SaveToCSV(dg_Report);
        }

        private void SaveToCSV(DataGridView DGV)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog
            {
                Filter = "Fichero CSV (*.csv)|*.csv",
                FileName = "",
                Title = "Exportar a CSV"
            };
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                System.Text.StringBuilder csvMemoria = new System.Text.StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < DGV.Columns.Count; i++)
                {
                    if (i == DGV.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            DGV.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\",",
                            DGV.Columns[i].HeaderText));
                    }
                }

                csvMemoria.AppendLine();


                for (int m = 0; m < DGV.Rows.Count; m++)
                {
                    for (int n = 0; n < DGV.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == DGV.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\",", DGV.Rows[m].Cells[n].Value, @"\d+"));
                        }

                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(dlGuardar.FileName, false, System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }

    }
}
