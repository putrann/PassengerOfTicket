﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DULIEU
{
    public class DAO_ChuyenXe
    {
        public DataTable LoadChuyenXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadChuyenXe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable LoadChuyenTheoTuyen(string Tuyen)
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadChuyenTheoTuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL ,
                    new SqlParameter { ParameterName = "@tuyen_id_tuyen" , Value = Tuyen}
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable LoadGioKH()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadGioKhoiHanh";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
       
        public DataTable LayChuyenTheoThoiGian(string Tuyen , DateTime batdau , DateTime ketthuc)
        {
            Provider kn = new Provider();
            string strSQL = "sp_LayChuyenTheoThoiGian";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@tuyen_id_tuyen", Value = Tuyen },
                    new SqlParameter { ParameterName = "@NgayBD", Value = batdau },
                    new SqlParameter { ParameterName = "@NgayKT", Value = ketthuc }
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable LoadIDXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDXe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable LoadIDChuyenXe()
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadIDChuyenXe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable FindGioKhoiHanh(string IDCHUYEN)
        {
            Provider kn = new Provider();
            string strSQL = "sp_FindGioKhoiHanhChuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter{ParameterName = "@id_chuyen" , Value = IDCHUYEN}
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        
        public DataTable LoadIDTuyen()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDTuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public DataTable LoadIDTuyenFromChuyen()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDTuyenFromChuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        
        public string GetIDTuyen(string ghichu)
        {
            Provider kn = new Provider();
            string strSQL = "sp_GetIDTuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter{ParameterName = "@GhiChu" , Value = ghichu}
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            DataRow row = dt.Rows[0];
            return row[0].ToString();
        }
        public DataTable GetIDChuyen(string ghichu)
        {
            Provider kn = new Provider();
            string strSQL = "sp_GetIDChuyen";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter{ParameterName = "@GhiChu" , Value = ghichu}
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        
        public DataTable LoadIDtx()
        {
            Provider kn = new Provider();
            string strSQL = "sp_IDTaiXe";
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            return dt;
        }
        public string LoadGhiChuChuyenXe(string idTuyen)
        {
            Provider kn = new Provider();
            string strSQL = "sp_LoadGhiChuChuyenXe"; // Stored Nay Nho' Distinct nhe'
            DataTable dt = new DataTable();
            try
            {
                kn.Connect();
                dt = kn.Select(CommandType.StoredProcedure, strSQL,
                    new SqlParameter {ParameterName = "@id_tuyen_id" , Value =idTuyen}
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                kn.Disconnect();
            }
            DataRow row = dt.Rows[0];
            return row[0].ToString();
            
        }
       
        public int ThemChuyenXe(ChuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_ThemChuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                        new SqlParameter { ParameterName = "@id_chuyen", Value = cm.id_chuyen },
                        new SqlParameter { ParameterName = "@tuyen_id_tuyen", Value = cm.tuyen_id_tuyen },
                        new SqlParameter { ParameterName = "@giokhoihanh", Value = cm.giokhoihanh },
                        new SqlParameter { ParameterName = "@xe_xeid", Value = cm.xe_xeid },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghichu },
                        new SqlParameter { ParameterName = "@tai_xe_id_taixe", Value = cm.tai_xe_id_taixe }
                        );
                flag = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return flag;
        }
        public int XoaChuyenXe(string idChuyen)
        {

            int flag = 0;
            Provider dbConnect = new Provider();
            try
            {
                string strSQL = "sp_XoaChuyenXe";
                dbConnect.Connect();
                dbConnect.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                      new SqlParameter { ParameterName = "@id_chuyen", Value = idChuyen }
                       );

                flag = 1;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                dbConnect.Disconnect();
            }
            return flag;

        }
        public int SuaChuyenXe(ChuyenXe cm)
        {
            int flag = 0;
            Provider provider = new Provider();
            try
            {
                string SqlStr = "sp_SuaChuyenXe";
                provider.Connect();
                provider.ExecuteNonQuery(CommandType.StoredProcedure, SqlStr,
                       new SqlParameter { ParameterName = "@id_chuyen", Value = cm.id_chuyen },
                        new SqlParameter { ParameterName = "@tuyen_id_tuyen", Value = cm.tuyen_id_tuyen },
                        new SqlParameter { ParameterName = "@giokhoihanh", Value = cm.giokhoihanh },
                        new SqlParameter { ParameterName = "@xe_xeid", Value = cm.xe_xeid },
                        new SqlParameter { ParameterName = "@ghichu", Value = cm.ghichu },
                        new SqlParameter { ParameterName = "@tai_xe_id_taixe", Value = cm.tai_xe_id_taixe }
                         );
                flag = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return flag;
        }
    }
}
