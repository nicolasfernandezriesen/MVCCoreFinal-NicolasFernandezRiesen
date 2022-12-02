using System.ComponentModel.DataAnnotations;
using SistemaWebEmpleado.Validations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        public string Dni { get; set; }

        [Required]
        [CheckValidLegajo]
        public string Legajo { get; set; }

        [Required]
        public string Titulo { get; set; }

        public Empleado() { }
        public Empleado(string nombre, string apellido, string dni, string legajo, string titulo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Legajo = legajo;
            this.Titulo = titulo;
        }
    }
}
