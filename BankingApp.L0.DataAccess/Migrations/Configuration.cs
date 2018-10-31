namespace BankingApp.L0.DataAccess.Migrations
{
    using BankingApp.L0.DataAccess.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BankingApp.L0.DataAccess.Infrastructure.BankingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankingApp.L0.DataAccess.Infrastructure.BankingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Comptes.AddOrUpdate(new Compte { Numero = "C1000", Proprietaire = "Admin", Solde = 1000M  });
            context.Comptes.AddOrUpdate(new Compte { Numero = "C2000", Proprietaire = "Krifa", Solde = 13000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "C3000", Proprietaire = "Chtioui", Solde = 5000M });
        }
    }
}
