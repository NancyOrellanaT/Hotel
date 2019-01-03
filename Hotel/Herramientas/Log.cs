using System;

namespace Hotel.Herramientas
{
    class Log
    {
        public static void Print(String mensaje)
        {
            Console.WriteLine("[" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "]: " + mensaje);
        }

    }
}
