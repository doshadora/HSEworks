using Microsoft.Reporting.WebForms;
using practice2.DAL;
using practice2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace practice2.Controllers
{
    public class StatsController : Controller
    {
        cswEntities cs = new cswEntities();
        public static IEnumerable<StatModel> result;
        public static DateTime d1;
        public static DateTime d2;

        // GET: Stats
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult MakeReport(DateTime dateOne, DateTime dateTwo)
        {
            int id = AccountController.id;
            SqlParameter[] store;

            if (dateOne < dateTwo)
            {
                d1 = dateOne;
                d2 = dateTwo;
                store = new SqlParameter[]{
                new SqlParameter("@store_id",id),
                new SqlParameter("@date_one",dateOne),
                new SqlParameter("@date_two",dateTwo)
            };
            }
            else
            {
                d2 = dateOne;
                d1 = dateTwo;
                store = new SqlParameter[]{
                new SqlParameter("@store_id",id),
                new SqlParameter("@date_one",dateTwo),
                new SqlParameter("@date_two",dateOne)
            };
            }

            result = cs.Database.SqlQuery<StatModel>("GetStats @store_id,@date_one,@date_two", store).ToList();

            return View(result);
        }

        public ActionResult Reports(string ReportType)
        {
            LocalReport lcr = new LocalReport();
            lcr.ReportPath = Server.MapPath("~/Reports/Stat.rdlc");

            ReportDataSource reportdata = new ReportDataSource();
            reportdata.Name = "statdata";
            reportdata.Value = result;
            lcr.DataSources.Add(reportdata);
            string rtype = ReportType;

            string gettype;
            string encoding;
            string fileNameExtention;

            if (rtype == "Excel")
            {
                fileNameExtention = "xlsx";
            }
            else if (rtype == "Word")
            {
                fileNameExtention = "docx";
            }

            string[] statData;
            Warning[] Alerts;
            byte[] renderByte;

            renderByte = lcr.Render(rtype, "", out gettype, out encoding, out fileNameExtention, out statData, out Alerts);
            Response.AddHeader("content-disposition", "attachment;filename = Отчет за период с " + d1 + " по " + d2 + "." + fileNameExtention);
            return File(renderByte, fileNameExtention);
        }
    }
}