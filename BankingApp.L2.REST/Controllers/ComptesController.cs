using BankingApp.L0.DataAccess.Domain;
using BankingApp.L1.Business.Facade;
using BankingApp.L1.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingApp.L2.REST.Controllers
{
    public class ComptesController : ApiController
    {
        private IComptesBusiness business = new CompteBusinessImpl();
        // GET api/comptes
        public IEnumerable<Compte> Get()
        {
            return business.TousLesComptes();
        }
    }
}
