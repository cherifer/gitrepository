using MinuTrade.Travel.Models;
using MinuTrade.Travel.Models.MinuTrade.Travel.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MinuTrade.Travel.Controllers
{
    public class PacoteViagemController : Controller
    {
        //
        // GET: /PacoteViagem/

        DataAccessContext objContext;

        public PacoteViagemController()
        {
            objContext = new DataAccessContext();
        }

        public ActionResult Index()
        {
            var userId = WebSecurity.GetUserId(User.Identity.Name);

            var user = objContext.User.First(u => u.UserId == userId);

            var pacotesViagens = objContext.PacoteViagens.Where(pc => pc.UserId == user.UserId).ToList();
            
            var returnValue = new List<PacoteViagem>();

            var minhasCidades = objContext.Cidades.ToList();

            var indice = 0;

            foreach (PacoteViagem pacote in pacotesViagens)
            {
                PacoteViagem pct = new PacoteViagem();

                pct.IdPacoteViagem = pacotesViagens[indice].IdPacoteViagem;
                pct.UserId = pacotesViagens[indice].UserId;
                pct.IdCidadeOrigem = pacotesViagens[indice].IdCidadeOrigem;
                pct.IdCidadeDestino = pacotesViagens[indice].IdCidadeDestino;
                pct.DataSaidaOrigem = pacotesViagens[indice].DataSaidaOrigem;
                pct.DataSaidoDestino = pacotesViagens[indice].DataSaidoDestino;
                pct.NivelSatisfacaoCliente = pacotesViagens[indice].NivelSatisfacaoCliente;
                pct.NomeCidadeOrigem = minhasCidades.Where(a=>a.IdCidade == pacotesViagens[indice].IdCidadeOrigem).FirstOrDefault().DescricaoCidade;
                pct.NomeCidadeDestino = minhasCidades.Where(a => a.IdCidade == pacotesViagens[indice].IdCidadeDestino).FirstOrDefault().DescricaoCidade;

                returnValue.Add(pct);

                indice++;
            }

            return View(returnValue);
        }

        public ActionResult Classificar(int id = 0)
        {
            PacoteViagem pacote = objContext.PacoteViagens.Find(id);

            var minhasCidades = objContext.Cidades.ToList();

            PacoteViagem pct = new PacoteViagem();

            pct.IdPacoteViagem = pacote.IdPacoteViagem;
            pct.UserId = pacote.UserId;
            pct.IdCidadeOrigem = pacote.IdCidadeOrigem;
            pct.IdCidadeDestino = pacote.IdCidadeDestino;
            pct.DataSaidaOrigem = pacote.DataSaidaOrigem;
            pct.DataSaidoDestino = pacote.DataSaidoDestino;
            pct.NivelSatisfacaoCliente = pacote.NivelSatisfacaoCliente;
            pct.NomeCidadeOrigem = minhasCidades.Where(a => a.IdCidade == pacote.IdCidadeOrigem).FirstOrDefault().DescricaoCidade;
            pct.NomeCidadeDestino = minhasCidades.Where(a => a.IdCidade == pacote.IdCidadeDestino).FirstOrDefault().DescricaoCidade;
            
            
            
            if (pacote == null)
            {
                return HttpNotFound();
            }
            return View(pct);
        }

        [HttpPost]
        public ActionResult Classificar(PacoteViagem pacote)
        {
            if (ModelState.IsValid)
            {
                objContext.Entry(pacote).State = EntityState.Modified;
                objContext.SaveChanges();
                return RedirectToAction("Index");
            }

            var pacotesViagens = objContext.PacoteViagens.ToList();
            return View(pacotesViagens);
        }
    }
}
