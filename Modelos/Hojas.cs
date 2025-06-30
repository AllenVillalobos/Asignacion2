using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    /// <summary>
    /// Representa una hoja clínica asociada a una mascota. 
    /// Contiene información sobre síntomas, diagnóstico, tratamiento, fechas y 
    /// usuarios que modifican o agregan datos
    /// </summary>
    public class Hojas
    {
        /// <summary>Identificador único de la hoja clínica</summary>
        private int identificador { get; set; }

        /// <summary>Descripción de los síntomas observados en la mascota</summary>
        private String sintomas { get; set; }

        /// <summary>Diagnóstico realizado con base en los síntomas</summary>
        private String diagnostico { get; set; }

        /// <summary>Tratamiento prescrito para la mascota</summary>
        private String tratamiento { get; set; }

        /// <summary>Identificador de la mascota a la que pertenece la hoja clínica</summary>
        private int idMascota { get; set; }

        /// <summary>Fecha en que se registró la hoja por primera vez</summary>
        private DateTime fechaAdicion { get; set; }

        /// <summary>Última fecha en que se modificó la hoja</summary>
        private DateTime fechaModificacion { get; set; }

        /// <summary>Nombre del usuario que registró la hoja clínica</summary>
        private String adicionadoPor { get; set; }

        /// <summary>Nombre del usuario que realizó la última modificación</summary>
        private String modificadorPor { get; set; }

        /// <summary>
        /// Constructor vacío requerido para instanciación sin parámetros
        /// Útil en procesos de serialización o cuando se llenan propiedades por separado
        /// </summary>
        public Hojas()
        {
        }

        /// <summary>
        /// Constructor para agregar una hoja clínica nueva
        /// No incluye modificación porque es la creación inicial
        /// </summary>
        public Hojas(int identificador, String sintomas, String diagnostico, 
            String tratamiento, int idMascota, DateTime fechaAdicion, String adicionadoPor)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.idMascota = idMascota;
            this.fechaAdicion = fechaAdicion;
            this.adicionadoPor = adicionadoPor;
        }

        /// <summary>
        /// Constructor para modificar una hoja existente
        /// No incluye datos de creación, solo campos editables y metadata de modificación
        /// </summary>
        public Hojas(int identificador, String sintomas, String diagnostico,
            String tratamiento, DateTime fechaModificacion, String modificadorPor)
        {
            this.identificador = identificador;
            this.sintomas = sintomas;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.fechaModificacion = fechaModificacion;
            this.modificadorPor = modificadorPor;
        }

        /// <summary>
        /// Devuelve una representación en texto de la hoja clínica
        /// Útil para mostrar información rápidamente en consola o logs
        /// </summary>
        override
        public String ToString()
        {
            return "Identificador: " + this.identificador + ", Sintomas: " + 
                this.sintomas + ", Diagnostico: " + this.diagnostico +
                   ", Tratamiento: " + this.tratamiento + ", ID Mascota: " + this.idMascota +
                   ", Fecha Adicion: " + this.fechaAdicion.ToString("dd/MM/yyyy") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("dd/MM/yyyy") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadorPor;
        }
    }
}
