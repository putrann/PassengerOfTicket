﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DULIEU;
using System.Data;
using System.Data.SqlClient;

namespace DULIEU
{
    public class DAO_Users
    {
        public int Authenticate(string tk, string pass)
        {
            Provider p = new Provider();
            try
            {
                p.Connect();
                string strSql = "sp_CheckUser";
                int flag = 0;
                DataTable dt = p.Select(CommandType.StoredProcedure, strSql,
                    new SqlParameter { ParameterName = "@ID",Value =tk },
                    new SqlParameter { ParameterName = "@Pass",Value = pass }
                    );
                foreach(DataRow row in dt.Rows)
                {
                    flag = Convert.ToInt32(row["KiemTra"]);
                }

                return flag;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.Disconnect();
            }
        }
    }
}
