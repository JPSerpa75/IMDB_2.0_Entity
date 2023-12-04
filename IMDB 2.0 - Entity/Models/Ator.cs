using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Ator
    {
        public long atorId { get; set; }
        public String nome { get; set; }
        public String sobrenome { get; set; }
        public virtual ICollection<Atuacao> atuacoes { get; set; }
    }
}