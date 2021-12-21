using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaCrud2.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Descrição { get; set; }
        public virtual ICollection<Promocao> Promocao { get; set; }

    }
}

