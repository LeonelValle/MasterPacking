using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Packing
{
    class Scan : Conexion
    {
        public int id_scan { get; set; }
        public string SN { get; set; }
        public DateTime dateScan { get; set; }
        public int id_wo { get; set; }
        public int id_box { get; set; }


    }
}
