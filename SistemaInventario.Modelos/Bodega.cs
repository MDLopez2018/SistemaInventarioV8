using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage="Nombre deber ser Maximo 60 caracters")]
        public int Nombre { get; set; }
        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion deber ser Maximo 60 caracters")]
        public int Descripcion { get; set; }
        [Required(ErrorMessage = "Estado es Requerido")]
        public bool Estado { get; set; }
    }
}
