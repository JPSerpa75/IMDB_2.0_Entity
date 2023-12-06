using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Ator
    {
        public long atorId { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public String nome { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório.")]
        public String sobrenome { get; set; }
        public virtual ICollection<Atuacao> atuacoes { get; set; }
    }
}