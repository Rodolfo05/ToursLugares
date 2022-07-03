using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entidades
{
    public class Lugar
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public double GastoAproximado { get; set; }
        public string ImgUrl { get; set; }
        public int IdPais { get; set; }

        [ForeignKey("IdPais")]
        public Pais Pais { get; set; }

        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
    }
}
