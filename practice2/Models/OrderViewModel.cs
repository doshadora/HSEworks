using PagedList;
using practice2.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using practice2.Controllers;

namespace practice2.Models
{
    public class OrderViewModel
    {
        cswEntities context = new cswEntities();
        public IEnumerable<cheque_set> ListOfOrders { get; set; }
        public IEnumerable<status_of_cheque> ListOfStatuses { get; set; }
        public IEnumerable<product_address> ListOfProducts { get; set; }
        public IEnumerable<dict_product_status> ListOfStats { get; set; }
        public IEnumerable<product> ListOfProds { get; set; }
        public IEnumerable<dict_size> ListOfSizes { get; set; }
        public IEnumerable<customer> ListOfCusts { get; set; }

        public OrderViewModel CreateModelStore()
        {
            int storeId = AccountController.id;

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<cheque_set> orderData = context.Database.SqlQuery<cheque_set>("OrderStatus_NoFilters @store_id", param).ToList();

            SqlParameter[] param1 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<status_of_cheque> statData = context.Database.SqlQuery<status_of_cheque>("OrderStatus_NoFilters @store_id", param1).ToList();

            SqlParameter[] param2 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<product_address> prodData = context.Database.SqlQuery<product_address>("OrderStatus_NoFilters @store_id", param2).ToList();

            SqlParameter[] param3 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<dict_product_status> statNameData = context.Database.SqlQuery<dict_product_status>("OrderStatus_NoFilters @store_id", param3).ToList();

            SqlParameter[] param4 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<product> prodNameData = context.Database.SqlQuery<product>("OrderStatus_NoFilters @store_id", param4).ToList();

            SqlParameter[] param5 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<dict_size> sizeData = context.Database.SqlQuery<dict_size>("OrderStatus_NoFilters @store_id", param5).ToList();

            SqlParameter[] param6 = new SqlParameter[]{
                new SqlParameter("@store_id",storeId)
            };
            IEnumerable<customer> custData = context.Database.SqlQuery<customer>("OrderStatus_NoFilters @store_id", param6).ToList();

            return new OrderViewModel
            {
                ListOfOrders = orderData,
                ListOfStatuses = statData,
                ListOfProducts = prodData,
                ListOfStats = statNameData,
                ListOfProds = prodNameData,
                ListOfSizes = sizeData,
                ListOfCusts = custData
            };
        }
        public OrderViewModel CreateModelCust()
        {
            int custId = AccountController.id;

            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<cheque_set> orderData = context.Database.SqlQuery<cheque_set>("GetCustOrder @cust_id", param).ToList();

            SqlParameter[] param1 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<status_of_cheque> statData = context.Database.SqlQuery<status_of_cheque>("GetCustOrder @cust_id", param1).ToList();

            SqlParameter[] param2 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<product_address> prodData = context.Database.SqlQuery<product_address>("GetCustOrder @cust_id", param2).ToList();

            SqlParameter[] param3 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<dict_product_status> statNameData = context.Database.SqlQuery<dict_product_status>("GetCustOrder @cust_id", param3).ToList();

            SqlParameter[] param4 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<product> prodNameData = context.Database.SqlQuery<product>("GetCustOrder @cust_id", param4).ToList();

            SqlParameter[] param5 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<dict_size> sizeData = context.Database.SqlQuery<dict_size>("GetCustOrder @cust_id", param5).ToList();

            SqlParameter[] param6 = new SqlParameter[]{
                new SqlParameter("@cust_id",custId)
            };
            IEnumerable<customer> custData = context.Database.SqlQuery<customer>("GetCustOrder @cust_id", param6).ToList();

            return new OrderViewModel
            {
                ListOfOrders = orderData,
                ListOfStatuses = statData,
                ListOfProducts = prodData,
                ListOfStats = statNameData,
                ListOfProds = prodNameData,
                ListOfSizes = sizeData,
                ListOfCusts = custData
            };
        }
    }
}