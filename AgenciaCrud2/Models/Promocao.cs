using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaCrud2.Models
{
    public class Promocao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public int DestinoID { get; set; }
        [ForeignKey("DestinoID")]
        public virtual Destino Destino { get; set; }

        public string Saida { get; set; }
        public string Retorno { get; set; }
        public float Valor { get; set; }
    }
}
