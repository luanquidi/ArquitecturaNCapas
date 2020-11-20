using System;
using System.Collections.Generic;
using System.Text;

namespace Em.ArquitecturaNCapas.Transversal.Respuesta
{
    public class RespuestaOperacion<T>
    {
        public  T Datos { get; set; }
        public  bool ResultadoExitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
