using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Models
{
    public class Filme
    {
        public long filmeId { get; set; }
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public String titulo { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public String descricao { get; set; }
        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public String categoria { get; set; }
        [Required(ErrorMessage = "O campo Idioma é obrigatório.")]
        public String idioma { get; set; }
        public String classificacaoIndicativa { get; set; }
        public int? anoLancamento { get; set; }
        public virtual ICollection<Atuacao> atuacoes { get; set; }

    }
}