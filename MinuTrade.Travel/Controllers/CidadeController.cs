using MinuTrade.Travel.Models.MinuTrade.Travel.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinuTrade.Travel.Controllers
{
    public class CidadeController : Controller
    {
        //
        // GET: /Cidade/

        DataAccessContext objContext;

        public CidadeController()
        {
            objContext = new DataAccessContext();
        }

        public ActionResult Index()
        {
            var cities = objContext.Cidades.ToList();
            return View(cities);
        }

    }
}
