using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asignacion2.Modelos
{
    /// <summary>
    /// Representa los datos de una mascota registrada en el sistema
    /// Incluye información general médica 
    /// </summary>
    public class Mascotas
    {
        /// <summary>Identificador único de la mascota en el sistema</summary>
        private int identificador { get; set; }

        /// <summary>Nombre de la mascota, registrado por el propietario</summary>
        private String nombre { get; set; }

        /// <summary>Lista de alergias que padece la mascota (si tiene)</summary>
        private String alergias { get; set; }

        /// <summary>Fecha de nacimiento de la mascota</summary>
        private DateTime fechaNacimiento { get; set; }

        /// <summary>Sexo de la mascota. Usualmente 'M' o 'H'.</summary>
        private char sexo { get; set; }

        /// <summary>Peso actual de la mascota en kilogramos</summary>
        private decimal peso { get; set; }

        /// <summary>ID del propietario al que pertenece la mascota</summary>
        private int idPropietario { get; set; }

        /// <summary>Fecha en que se registró la mascota por primera vez</summary>
        private DateTime fechaAdicion { get; set; }

        /// <summary>Fecha de la última modificación a los datos de la mascota</summary>
        private DateTime fechaModificacion { get; set; }

        /// <summary>Nombre del usuario que registró inicialmente la mascota</summary>
        private String adicionadoPor { get; set; }

        /// <summary>Nombre del usuario que hizo la última modificación</summary>
        private String modificadorPor { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// Útil para serialización o creación de objetos vacíos
        /// </summary>
        public Mascotas()
        {
        }

        /// <summary>
        /// Constructor completo para registrar una nueva mascota
        /// Incluye todos los datos requeridos excepto la modificación
        /// </summary>
        public Mascotas(int identificador, String nombre, String alergias, 
            DateTime fechaNacimiento, char sexo, decimal peso, 
            int idPropietario, DateTime fechaAdicion, String adicionadoPor)
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

        /// <summary>
        /// Constructor para modificar datos de una mascota ya existente
        /// Omite campos que no cambian
        /// </summary>
        public Mascotas(int identificador, String nombre, String alergias, decimal peso, DateTime fechaModificacion, String modificadorPor)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.alergias = alergias;
            this.peso = peso;
            this.fechaModificacion = fechaModificacion;
            this.modificadorPor = modificadorPor;
        }

        /// <summary>
        /// Retorna  un texto de los datos de la mascota
        /// Útil para mostrar información rápida en consola o bitácoras
        /// </summary>
        override
        public string ToString()
        {
            return "Identificador: " + this.identificador + ", Nombre: " + this.nombre + ", Alergias: " + this.alergias +
                   ", Fecha Nacimiento: " + this.fechaNacimiento.ToString("dd/MM/yyyy") + ", Sexo: " + this.sexo +
                   ", Peso: " + this.peso + ", ID Propietario: " + this.idPropietario +
                   ", Fecha Adicion: " + this.fechaAdicion.ToString("dd/MM/yyyy") +
                   ", Fecha Modificacion: " + this.fechaModificacion.ToString("dd/MM/yyyy") +
                   ", Adicionado Por: " + this.adicionadoPor + ", Modificado Por: " + this.modificadorPor;
        }
    }
}
