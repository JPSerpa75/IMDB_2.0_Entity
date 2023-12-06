using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Atuacao
    {
        public long? atuacaoId { get; set; }
        [Required(ErrorMessage = "O campo Ator é obrigatório.")]
        public long? atorId { get; set; }
        [Required(ErrorMessage = "O campo Filme é obrigatório.")]
        public long? filmeId { get; set; }
        public Ator ator { get; set; }
        public Filme filme { get; set; }
    }
}