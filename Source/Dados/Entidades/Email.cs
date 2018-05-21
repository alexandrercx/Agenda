using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Dados.Entidades
{
    public class Email : Entidade
    {

        public int IdContato { get; set; }

        public int IdClassificacao { get; set; }

        public string EnderecoEmail { get; set; }

        [NotMapped]
        public bool Removido { get; set; }



        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
