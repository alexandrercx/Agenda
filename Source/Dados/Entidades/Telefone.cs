using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dados.Entidades
{
    public class Telefone : Entidade
    {

        public string Numero { get; set; }

        public int IdContato { get; set; }

        public int IdClassificacao { get; set; }

        [NotMapped]
        public bool Removido { get; set; }


        #region Validate
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (IdContato == 0)
                yield return new ValidationResult("Contato não foi informado", new[] { "IdContato" });
        }

        #endregion

       
    }
}
