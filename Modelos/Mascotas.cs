using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    public class Mascotas
    {
        private int identificador { get; set; }
        private String nombre { get; set; }
        private String alergias { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private char sexo { get; set; }
        private decimal peso { get; set; }
        private int idPropietario { get; set; }
        private DateTime fechaAdicion { get; set; }
        private DateTime fechaModificacion { get; set; }
        private String adicionadoPor { get; set; }
        private String modificadorPor { get; set; }

        public Mascotas()
        {
        }

        public Mascotas(int identificador, String nombre, String alergias, DateTime fechaNacimiento, char sexo, decimal peso, int idPropietario, DateTime fechaAdicion, String adicionadoPor)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.alergias = alergias;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.peso = peso;
            this.idPropietario = idPropietario;
            this.fechaAdicion = fechaAdicion;
            this.adicionadoPor = adicionadoPor;
        }

        public Mascotas(int identificador, String nombre, String alergias, decimal peso, DateTime fechaModificacion, String modificadorPor)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.alergias = alergias;
            this.peso = peso;
            this.fechaModificacion = fechaModificacion;
            this.modificadorPor = modificadorPor;
        }

        override
        public string ToString()
        {
            return "Identificador: " + this.identificador + ", Nombre: " + this.nombre + ", Alergias: " + this.alergias +
                   ", Fecha Nacimiento: " + this.fechaNacimiento.ToString("d") + ", Sexo: " + this.sexo +
                   ", Peso: " + this.peso + ", ID Propietario: " + this.idPropietario +
                   ", Fecha Adicion: " + this.fechaAdicion.ToString("d") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("d") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadorPor;
        }
    }
}