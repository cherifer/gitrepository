using MinuTrade.Travel.Models;
using MinuTrade.Travel.Models.MinuTrade.Travel.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinuTrade.Travel.Helpers
{
    public class ModelsToLists
    {
        public static Cidade ObterCidadeById(int id)
        {
            Cidade _cidade = new Cidade();
            using (DataAccessContext db = new DataAccessContext())
            {
                _cidade = db.Cidades.Where(c => c.IdCidade == id).FirstOrDefault();
            }

            return _cidade;
        }

        public static Cidade ObterCidadeByEstadoId(int id)
        {
            Cidade _cidade = new Cidade();
            using (DataAccessContext db = new DataAccessContext())
            {
                _cidade = db.Cidades.Where(c => c.IdEstado == id).FirstOrDefault();
            }

            return _cidade;
        }

        public static Estado ObterEstadoById(int id)
        {
            Estado _estado = new Estado();
            using (DataAccessContext db = new DataAccessContext())
            {
                _estado = db.Estados.Where(c => c.IdEstado == id).FirstOrDefault();
            }

            return _estado;
        }
    }
}