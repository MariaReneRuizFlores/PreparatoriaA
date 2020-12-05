

namespace PreparatoriaA.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        public enum Lista
        {
            ingenieria = 10,
            humanidades = 20,
            artes = 30
        }
        [Key]
        public int EstudianteID { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Nombre")]
        public string EstudianteNombre { get; set; }

        [StringLength(20)]
        [Display(Name = "Apellido")]
        public string EstudianteApellido { get; set; }

        [Display(Name = "Facultad")]
        public Lista EstudianteFacultad { get; set; }
    }
}