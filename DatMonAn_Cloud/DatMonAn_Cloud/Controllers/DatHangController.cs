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
    public class DatHangController : ApiController
    {
        private DatmonanEntities db = new DatmonanEntities();
        [Route("api/DatHangPost")]
        [HttpPost]
        public IHttpActionResult PostTaiKhoans([FromBody] ModelDatHang d)
        {
            // taiKhoan = "admin@gmail.com"
            // pass = "123456789"
            var exProc = db.Database.SqlQuery<int>("exec DatHang_Insert @TenTaiKhoan, @TenNhaHang, @ThoiGian, @TrangThai, @TenMonAn, @SoLuong",
               new SqlParameter("TenTaiKhoan", d.TenTaiKhoan),
               new SqlParameter("TenNhaHang", d.TenNhaHang),
               new SqlParameter("ThoiGian", d.ThoiGian),
               new SqlParameter("TrangThai", d.TrangThai),
               new SqlParameter("TenMonAn", d.TenMonAn),
               new SqlParameter("SoLuong", d.SoLuong)
               )
               .ToArray();
            //IEnumerable<string> result = res;
            int kq = exProc[0];
            return Ok(kq);
        }
    }
}
