using PagedList;
using practice2.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace practice2.Models.Home
{
    public class HomeIndexViewModel
    {
        cswEntities context = new cswEntities();
        public IEnumerable<product> ListOfProducts { get; set; }
        public IEnumerable<price> ListOfPrices { get; set; }

        public HomeIndexViewModel CreateModel(string search)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@search",search??(object)DBNull.Value)
            };

            SqlParameter[] param1 = new SqlParameter[]{
                new SqlParameter("@search",search??(object)DBNull.Value)
            };

            IEnumerable<product> prodData = context.Database.SqlQuery<product>("GetBySearch @search", param).ToList();
            IEnumerable<price> priceData = context.Database.SqlQuery<price>("GetBySearch @search", param1).ToList();

            return new HomeIndexViewModel
            {
                ListOfProducts = prodData,
                ListOfPrices = priceData
            };
        }
    }
}