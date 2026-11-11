using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public int Orden {  get; set; }
        public bool Estado {  get; set; }
    }
}
