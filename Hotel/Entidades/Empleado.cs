using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entidades
{
    class Empleado
    {

        public int CodigoEmpleado { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string CI { get; set; }
        public string Direccion { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public Empleado(int codigoEmpleado, string nombres, string apellidoPaterno, string apellidoMaterno, string telefono, string celular, string ci, string direccion, string usuario, string contrasena)
        {
            this.CodigoEmpleado = codigoEmpleado;
            this.Nombres = nombres;
            this.ApellidoPaterno = apellidoPaterno;
            this.Telefono = telefono;
            this.Celular = celular;
            this.CI = ci;
            this.Direccion = direccion;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }
    }
}
