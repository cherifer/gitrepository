using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MinuTrade.Travel.Models
{
    namespace MinuTrade.Travel.DataAccess.Models
    {
        public class DataAccessContext : DbContext
        {
            public DataAccessContext()
                : base("MinuTradeDBContext")
            {
            }

            public DbSet<Users> User { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Estado> Estados { get; set; }
            public DbSet<PacoteViagem> PacoteViagens { get; set; }
        }
    }
}