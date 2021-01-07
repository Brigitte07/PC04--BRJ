using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica3.Models
{
    //[Table("Tb_Registrar")]    
    public class Registrar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Required(ErrorMessage = "Titulo")]   
        [Display(Name="Titulo ")]
        [Column("Titulo")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "Por favor ingrese Img")]   
        [Display(Name="Img: ")]
        [Column("Img")]
        public string Img { get; set; }

        

        [Required(ErrorMessage = "Por favor ingrese Fecha")]   
        [Display(Name="Fecha: ")]
        [Column("Fecha")]
       public DateTime Fecha { get; set; }
        


    }
    
}