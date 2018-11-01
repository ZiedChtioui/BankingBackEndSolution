namespace ScaffoldedBanking.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelBanking : DbContext
    {
        public ModelBanking()
            : base("name=ModelBanking")
        {
        }

        public virtual DbSet<Compte> Comptes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
