using System.ComponentModel.DataAnnotations;

namespace MiJardin.Models
{

    public enum IluType
    {
        Soldirecto = 0,
        Semisombra = 1,
        Sombra= 2,
    }
    public class Plant
    {
        [Key]
        public int PlantID { get; set; }


        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        [Display(Name = "Nombre (Especie)")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        [Display(Name = "Tipo de Iluminacion")]
        public IluType Iluminacion { get; set; }


        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        [Display(Name = "Días de Riego")]
        public string Riego { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        [Display(Name = "Fertilizacion")]
        public string Fertilizacion { get; set; }




    }
}
