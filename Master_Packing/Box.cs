namespace Master_Packing
{
    class Box : Conexion
    {
        int id_box;
        string box;
        int count;
        bool parcial;

        public int Id_box { get => id_box; set => id_box = value; }
        public string Boxes { get => box; set => box = value; }
        public int Count { get => count; set => count = value; }
        public bool Parcial { get => parcial; set => parcial = value; }
    }
}
