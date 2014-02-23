using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinuTrade.Travel.DataAccess.Models
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext()
            : base("MinuTradeDBContext")
        {
        }

        public DbSet<Users> User { get; set; }
    }
}
