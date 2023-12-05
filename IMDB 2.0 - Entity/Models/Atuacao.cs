using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Atuacao
    {
        public long? atuacaoId { get; set; }
        public long? atorId { get; set; }
        public long? filmeId { get; set; }
        public Ator ator { get; set; }
        public Filme filme { get; set; }
    }
}