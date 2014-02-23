using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using MinuTrade.Travel.DataAccess.Models;

namespace MinuTrade.Travel.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlDataReader rdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            Int16 totalReg = 0;
            try
            {

                String strCon = ConfigurationManager.ConnectionStrings["MinuTradeDBContext"].ConnectionString;
                con = new SqlConnection(strCon);
                con.Open();

                string sql = "SELECT * FROM Users";
                cmd = new SqlCommand(sql);
                cmd.Connection = con;

                List<string> nomes = new List<string>();

                // Executa a cosulta
                rdr = cmd.ExecuteReader();

                //percorre o leitor e exibe os valores no listbox
                while (rdr.Read())
                {
                    nomes.Add(rdr["Username"].ToString() + " - " + rdr["Password"].ToString());
                    totalReg += 1;
                }

                var teste = nomes;
            }
            catch (Exception ex)
            {
                // mensagem de erro
                throw new Exception(ex.Message);
            }
            finally
            {
                // fecha os objetos datareader e connection
                if (rdr != null)
                    rdr.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            Assert.AreEqual(3, totalReg);
        }


        [TestMethod]
        public void TestMethod2()
        {
            var db = new DataAccessContext();

            var usr = new Users() { Username = "usrteste" };
            db.User.Add(usr);
            var gravou = db.SaveChanges();

            var teste = gravou;
        }
    }
}
