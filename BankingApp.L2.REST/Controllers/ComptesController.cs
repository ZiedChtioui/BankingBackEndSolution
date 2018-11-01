using BankingApp.L0.DataAccess.Domain;
using BankingApp.L1.Business.Facade;
using BankingApp.L1.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BankingApp.L2.REST.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ComptesController : ApiController
    {
        private IComptesBusiness business;// = new CompteBusinessImpl();

        public ComptesController(IComptesBusiness business)
        {
            this.business = business;
        }
        // GET api/comptes
        public IEnumerable<Compte> Get()
        {
            return business.TousLesComptes();
        }
    }
}
