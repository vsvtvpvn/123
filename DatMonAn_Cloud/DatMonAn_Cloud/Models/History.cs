﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatMonAn_Cloud.Models
{
    public class History
    {
        public int ID_DonHang { get; set; }
        public String TenNhaHang { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set; }
        public DateTime ThoiGian { get; set; }
        public int TrangThai { get; set; }
}
}