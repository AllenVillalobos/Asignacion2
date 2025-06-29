using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    /// <summary>
    /// Representa a un usuario del sistema
    /// Contiene la información básica de autenticación
    /// </summary>
    public class Usuarios
    {
        /// <summary>Identificador único del usuario en la base de datos</summary>
        private int identificador { get; set; }

        /// <summary>Nombre de usuario para iniciar sesión en el sistema</summary>
        private String usuario { get; set; }

        /// <summary>Clave o contraseña asociada al usuario. Se recomienda manejarla de forma segura</summary>
        private string clave { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Usuarios()
        {
        }

        /// <summary>
        /// Constructor para crear un usuario con nombre y clave
        /// </summary>
        public Usuarios(String usuario, String clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }

        /// <summary>
        /// Constructor completo que incluye el identificador del usuario
        /// Útil cuando ya existe el usuario en la base de datos
        /// </summary>
        public Usuarios(int identificador, String usuario, String clave)
        {
            this.identificador = identificador;
            this.usuario = usuario;
            this.clave = clave;
        }

        /// <summary>
        /// Devuelve un texto de la informacion del usuario
        /// </summary>
        override
        public string ToString()
        {
            return "Nombre Usuario: " + this.usuario + " Clave: " + this.clave + " Id: " + this.identificador;
        }
    }
}
