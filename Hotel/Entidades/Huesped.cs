namespace Hotel
{
    class Huesped
    {
        public int CodigoHuesped { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CI { get; set; }

        public Huesped(string nombres, string apellidoPaterno, string apellidoMaterno, string ci)
        {
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            CI = ci;
        }

        public Huesped(int codigoHuesped, string nombres, string apellidoPaterno, string apellidoMaterno, string ci)
        {
            CodigoHuesped = codigoHuesped;
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            CI = ci;
        }

    }
}