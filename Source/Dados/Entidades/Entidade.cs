using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Dados.Entidades
{
    public abstract class Entidade : IValidatableObject
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        #region Métodos

        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

        public void Validar()
        {
            var erros = Validate(null);
            if (erros.Count() > 0)
            {
                var mensagem = new StringBuilder();
                foreach (var erro in erros)
                    mensagem.Append(string.Format("{0}\n", erro.ErrorMessage));

                throw new ValidationException(mensagem.ToString());
            }
        }

        #endregion
    }
}
