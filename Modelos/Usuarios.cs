using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    public class Usuarios
    {
        private int identificador { get; set;}
        private String usuario { get; set; }
        private string clave { get; set; }

        public Usuarios()
        {
            this.identificador = 0;
            this.usuario = "";
            this.clave = "";
        }

        public Usuarios(String usuario, String clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }
        public Usuarios(int identificador, String usuario, String clave)
        {
            this.identificador = identificador;
            this.usuario = usuario;
            this.clave = clave;
        }

        override
        public string ToString()
        {
            return "Nombre Usuario: "+ this.usuario+" Clave: "+this.clave+" Id: "+this.identificador;
        }
    }
}