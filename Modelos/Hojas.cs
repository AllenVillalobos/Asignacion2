using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    public class Hojas
    {
        private int identificador { get; set; }
        private String sintomas { get; set; }
        private String diagnostico { get; set; }
        private String tratamiento { get; set; }
        private int idMascota { get; set; }
        private DateTime fechaAdicion { get; set; }
        private DateTime fechaModificacion { get; set; }
        private String adicionadoPor { get; set; }
        private String modificadorPor { get; set; }

        public Hojas()
        {
        }
        public Hojas(int identificador, String sintomas, String diagnostico, String tratamiento, int idMascota, DateTime fechaAdicion, String adicionadoPor)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.idMascota = idMascota;
            this.fechaAdicion = fechaAdicion;
            this.adicionadoPor = adicionadoPor;
        }
        public Hojas(int identificador, String sintomas, String diagnostico, String tratamiento, DateTime fechaModificacion, String modificadorPor)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.fechaModificacion = fechaModificacion;
            this.modificadorPor = modificadorPor;
        }

        override
        public String ToString()
        {
            return "Identificador: " + this.identificador + ", Sintomas: " + this.sintomas + ", Diagnostico: " + this.diagnostico +
                   ", Tratamiento: " + this.tratamiento + ", ID Mascota: " + this.idMascota +
                   ", Fecha Adicion: " + this.fechaAdicion.ToString("d") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("d") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadorPor;
        }
    }
}