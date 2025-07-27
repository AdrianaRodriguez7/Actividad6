using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ApiEjemplo.Models
{
    public class Producto
    {
        //definiendo la clase que representa los datos que se guardarán en la base de datos
        public int Id {  get; set; } //mi llave primaria
        public string Nombre { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; } 
    }
}
