using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Filme
    {
        public long filmeId { get; set; }
        public String titulo { get; set; }
        public String descricao { get; set; }
        public String categoria { get; set; }
        public String idioma { get; set; }
        public String classificacaoIndicativa { get; set; }
        public int? anoLancamento { get; set; }
        public virtual ICollection<Atuacao> atuacoes { get; set; }

    }
}