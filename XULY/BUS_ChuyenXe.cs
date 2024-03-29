﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
namespace XULY
{
    public class BUS_ChuyenXe
    {
        public DataTable LoadChuyenXe()
        {
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = CX.LoadChuyenXe();
            return dt;
        }
        public DataTable LoadChuyenXeTheoTuyen(string Tuyen)
        {
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = CX.LoadChuyenTheoTuyen(Tuyen);
            return dt;
        }
        public DataTable LoadGioKhoiHanh()
        {
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = CX.LoadGioKH();
            return dt;
        }
        public DataTable LoadChuyenXeTheoThoiGian(string Tuyen , DateTime a , DateTime b)
        {
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = CX.LayChuyenTheoThoiGian(Tuyen, a, b);
            return dt;
        }
        public List<string> LoadIDChuyenXe()
        {
            DAO_ChuyenXe Cxe = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = Cxe.LoadIDChuyenXe();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public int ThemChuyenXe(ChuyenXe a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            DataTable dt = CX.LoadIDChuyenXe();
            foreach (DataRow row in dt.Rows)
            {
                if (a.id_chuyen == row[0].ToString())
                {
                    return -1;
                }
            }
            kq = CX.ThemChuyenXe(a);
            return kq;
        }
        public int SuaChuyenXe(ChuyenXe a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            kq = CX.SuaChuyenXe(a);
            return kq;
        }
        public int XoaChuyenXe(string a)
        {
            int kq = 0;
            DAO_ChuyenXe CX = new DAO_ChuyenXe();
            kq = CX.XoaChuyenXe(a);
            return kq;
        }
        public List<string> LoadIDXe()
        {
            DAO_ChuyenXe Cxe = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = Cxe.LoadIDXe();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> LoadIDTuyen()
        {
            DAO_ChuyenXe Cxe = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = Cxe.LoadIDTuyen();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> LoadIDTuyenFromChuyen()
        {
            DAO_ChuyenXe Cxe = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = Cxe.LoadIDTuyenFromChuyen();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        
        public List<string> LoadIDTaiXe()
        {
            DAO_ChuyenXe Cxe = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = Cxe.LoadIDtx();
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public List<string> GetIDChuyen(string ghichu)
        {
            DAO_ChuyenXe cx = new DAO_ChuyenXe();
            DataTable idchuyen = cx.GetIDChuyen(ghichu);
            List<string> list = new List<string>();
            foreach (DataRow row in idchuyen.Rows)
            {
                list.Add(row[0].ToString());
            }
            return list;
        }
        public string GetIDTuyen(string ghichu)
        {
            DAO_ChuyenXe cx = new DAO_ChuyenXe();
            string kq = cx.GetIDTuyen(ghichu);
            return kq;
        }
        public DataTable TimGioKhoiHanh(string tenT)
        {
            DAO_ChuyenXe c = new DAO_ChuyenXe();
            DataTable dt = new DataTable();
            dt = c.FindGioKhoiHanh(tenT);
            return dt;
        }
        
    }
}
