using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Dados.Entidades
{

    public class Contato : Entidade
    {
        public Contato()
        {
            colecaoTelefone = new List<Telefone>();
            colecaoEmail = new List<Email>();
        }

        public string Nome { get; set; }

        public string Empresa { get; set; }

        public string Endereco { get; set; }

        public virtual List<Telefone> colecaoTelefone { get; set; }

        public virtual List<Email> colecaoEmail { get; set; }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }

        #region FluentAPI

        internal sealed class Configuration : EntityTypeConfiguration<Contato>
        {
            public Configuration()
            {

                HasMany(c => c.colecaoTelefone).WithRequired().HasForeignKey(c => new { c.IdContato }).WillCascadeOnDelete(true);
                HasMany(c => c.colecaoEmail).WithRequired().HasForeignKey(c => new { c.IdContato }).WillCascadeOnDelete(true);
            }
        }

        #endregion
    }
}
