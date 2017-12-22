using DatMonAn_Cloud.Entity;
using DatMonAn_Cloud.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatMonAn_Cloud.Controllers
{
    public class HistoriesController : ApiController
    {
        private DatmonanEntities db = new DatmonanEntities();

        // GET api/Histories
        public List<History> GetTaiKhoans(string taiKhoan)
        {
            var exProc = db.Database.SqlQuery<History>("exec SelectHistoryByAccountName @TenTaiKhoan",
               new SqlParameter("TenTaiKhoan", taiKhoan)).ToList();
           
            return exProc;
        }
    }
}
