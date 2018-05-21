using Dados.Entidades;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Objects;

namespace Dados.Contextos
{
    public class Contexto : DbContext
    {
        public bool IsDisposed { get; set; }


        public DbSet<Classificacao> Classificacao { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Telefone> Telefone { get; set; }



        public ObjectContext ObjectContext
        {
            get { return ((IObjectContextAdapter)this).ObjectContext; }
        }

        public Contexto()
            : base(@"Data Source=ALEXANDRE-PC\SQLEXPRESS;Initial Catalog=DbAgenda;Persist Security Info=True;User ID=userAgenda;Password=senh@") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new Contato.Configuration());


        }

        public void DetachAll()
        {
            if (IsDisposed)
                return;

            foreach (var entry in ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Deleted | EntityState.Modified | EntityState.Unchanged))
            {
                ObjectContext.Detach(entry.Entity);
            }
        }

        public void Detach(object entidade)
        {
            if (IsDisposed)
                return;

            ObjectContext.Detach(entidade);
        }

        protected override void Dispose(bool disposing)
        {
            DetachAll();
            IsDisposed = true;
            base.Dispose(disposing);
        }
    }
}
