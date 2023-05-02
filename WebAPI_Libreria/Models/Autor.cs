using System.ComponentModel.DataAnnotations;

namespace WebAPI_Libreria.Models
{
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        

    }
}
