using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    public class Propietarios
    {
        private int identificador { get; set; }
        private String primerNombre { get; set; }
        private String segundoNombre { get; set; }
        private String primerApellido { get; set; }
        private String segundoApellido { get; set; }
        private String numeroIdentificacion { get; set; }
        private String correoElectronico { get; set; }
        private String telefonoCelular { get; set; }
        private DateTime fechaAdicion { get; set; }
        private DateTime fechaModificacion { get; set; }
        private String adicionadoPor { get; set; }
        private String modificadoPor { get; set; }

        public Propietarios()
        {
        }

        public Propietarios(int identificador, String primerNombre, String segundoNombre, String primerApellido, String segundoApellido, String numeroIdentificacion, String correoElectronico, String telefonoCelular, DateTime fechaAdicion, String adicionadoPor)
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

        public Propietarios(int identificador, String primerNombre, String primerApellido, String segundoApellido,String correoElectronico, String telefonoCelular, String modificadoPor, DateTime fechaModificacion)
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

        override
        public string ToString()
        {
            return "Identificador: " + this.identificador + ", Nombre: " + this.primerNombre + " " + this.segundoNombre + ", Apellido: " + this.primerApellido + " " + this.segundoApellido +
                   ", Numero Identificacion: " + this.numeroIdentificacion + ", Correo Electronico: " + this.correoElectronico +
                   ", Telefono Celular: " + this.telefonoCelular + ", Fecha Adicion: " + this.fechaAdicion.ToString("d") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("d") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadoPor;
        }
    }
}