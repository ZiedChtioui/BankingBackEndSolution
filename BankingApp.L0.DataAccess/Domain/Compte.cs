using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Domain
{
    public class Compte
    {
        [Key]
        public string  Numero { get; set; }

        public string Proprietaire { get; set; }

        public decimal Solde { get; set; }

        public void Debiter(decimal montant)
        {
            Solde += montant;
        }

        public void Crediter(decimal montant)
        {
            Solde -= montant;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Compte converti = obj as Compte;

            return Numero.Equals(converti.Numero);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }
    }
}
