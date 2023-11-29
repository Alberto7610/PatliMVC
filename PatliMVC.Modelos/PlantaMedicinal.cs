using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.Modelos
{
    public class PlantaMedicinal
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre comun es obligatorio.")]
        [StringLength(50, ErrorMessage ="El nombre no puede exceder 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo debe contener letras y espacios.")]
        public string? NombreComun { get; set; }

        [Required(ErrorMessage = "El nombre cientifio es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo debe contener letras y espacios.")]
        public string? NombreCientifico { get; set; }

        [Required(ErrorMessage = "El nombre en Nahuatl es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo debe contener letras y espacios.")]
        public string? NombreNahuatl { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo solo debe contener letras y espacios.")]
        [StringLength(2500, ErrorMessage = "La descripción no debe superar los 2500 caracteres.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El uso medicinale es obligatorio.")]
        [StringLength(2500, ErrorMessage = "El uso medicinal no debe superar los 2500 caracteres.")]
        public string? UsoMedicinal { get; set; }

        [Required(ErrorMessage = "Las contraindicaciones son obligatorias.")]
        [StringLength(2500, ErrorMessage = "Las contraindicaciones no debe superar los 2500 caracteres.")]
        public string? Contraindicaciones { get; set; }

        [Required(ErrorMessage = "La evaluación cientifica es obligatoria.")]
        [StringLength(2500, ErrorMessage = "La evaluación no debe superar los 2500 caracteres.")]
        public string? EvaluacionCientifica { get; set; }

        public string? Imagen { get; set; }

        [Required(ErrorMessage = "El estado de la planta es obligatorio.")]
        [StringLength(50, ErrorMessage = "El estado no puede exceder 50 caracteres")]
        public bool Aprobado { get; set; }=false;
            
    }
}
