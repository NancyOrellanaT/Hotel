namespace Hotel
{
    class Huesped
    {
        public int CodigoHuesped { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CI { get; set; }

        public Huesped(int codigoHuesped, string nombres, string apellidoPaterno, string apellidoMaterno, string ci)
        {
            this.CodigoHuesped = codigoHuesped;
            this.Nombres = nombres;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.CI = ci;
        }

    }
}