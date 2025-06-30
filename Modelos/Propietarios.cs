using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    /// <summary>
    /// Representa a un propietario de una o más mascotas dentro del sistema
    /// Almacena información personal y datos
    /// </summary>
    public class Propietarios
    {
        /// <summary>Identificador único del propietario</summary>
        private int identificador { get; set; }

        /// <summary>Primer nombre del propietario</summary>
        private String primerNombre { get; set; }

        /// <summary>Segundo nombre del propietario (opcional)</summary>
        private String segundoNombre { get; set; }

        /// <summary>Primer apellido del propietario</summary>
        private String primerApellido { get; set; }

        /// <summary>Segundo apellido del propietario (opcional)</summary>
        private String segundoApellido { get; set; }

        /// <summary>Número de identificación oficial del propietario</summary>
        private String numeroIdentificacion { get; set; }

        /// <summary>Correo electrónico de contacto del propietario</summary>
        private String correoElectronico { get; set; }

        /// <summary>Número de teléfono celular del propietario</summary>
        private String telefonoCelular { get; set; }

        /// <summary>Fecha en la que se registró inicialmente al propietario</summary>
        private DateTime fechaAdicion { get; set; }

        /// <summary>Última fecha en la que se modificaron los datos del propietario (opcional)</summary>
        private DateTime fechaModificacion { get; set; }

        /// <summary>Nombre del usuario que realizó el registro del propietario</summary>
        private String adicionadoPor { get; set; }

        /// <summary>Nombre del usuario que realizó la última modificación (opcional)</summary>
        private String modificadoPor { get; set; }

        /// <summary>
        /// Constructor sin parámetros. Se usa cuando se requiere una instancia vacía
        /// Es útil para deserialización o cuando se asignan propiedades manualmente
        /// </summary>
        public Propietarios()
        {
        }

        /// <summary>
        /// Constructor completo para registrar un nuevo propietario
        /// Incluye todos los datos personales y de trazabilidad inicial
        /// </summary>
        public Propietarios(int identificador, String primerNombre, String segundoNombre, 
            String primerApellido, String segundoApellido, String numeroIdentificacion, 
            String correoElectronico, String telefonoCelular, DateTime fechaAdicion, String adicionadoPor)
        {
            this.identificador = identificador;
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.numeroIdentificacion = numeroIdentificacion;
            this.correoElectronico = correoElectronico;
            this.telefonoCelular = telefonoCelular;
            this.fechaAdicion = fechaAdicion;
            this.adicionadoPor = adicionadoPor;
        }

        /// <summary>
        /// Constructor utilizado para actualizar los datos de un propietario ya registrado
        /// Solo se incluyen los campos que pueden ser modificados
        /// </summary>
        public Propietarios(int identificador, String primerNombre, 
            String primerApellido, String segundoApellido, 
            String correoElectronico, String telefonoCelular, 
            String modificadoPor, DateTime fechaModificacion)
        {
            this.identificador = identificador;
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.correoElectronico = correoElectronico;
            this.telefonoCelular = telefonoCelular;
            this.modificadoPor = modificadoPor;
            this.fechaModificacion = fechaModificacion;
        }

        /// <summary>
        /// Devuelve un texto con toda la información del propietario
        /// Útil para mostrar en consola
        /// </summary>
        override
        public string ToString()
        {
            return "Identificador: " + this.identificador + ", Nombre: " + this.primerNombre + " " 
                + this.segundoNombre + ", Apellido: " + this.primerApellido + " " + this.segundoApellido +
                   ", Numero Identificacion: " + this.numeroIdentificacion + 
                   ", Correo Electronico: " + this.correoElectronico +
                   ", Telefono Celular: " + this.telefonoCelular + 
                   ", Fecha Adicion: " + this.fechaAdicion.ToString("dd/MM/yyyy") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("dd/MM/yyyy") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadoPor;
        }
    }
}
