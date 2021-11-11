using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAL
{
    class DBHELP
    {
        //public bool UsersSelect(string pName, SqlParameter [] ps)   //用户查询的方法
        //{
        //    SqlConnection con = null;
        //    SqlCommand cmd = null;
        //    try
        //    {
                
        //        con = new SqlConnection(ConfigurationManager.AppSettings["strcon"]);
        //        con.Open();
        //        cmd = new SqlCommand(pName, con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddRange(ps);
        //        cmd.ExecuteNonQuery();
        //        return true;  
                
        //    }
        //    catch (Exception)
        //    {

        //         return false;
        //    }
        //    finally
        //    {
        //        con.Close();
        //        con.Dispose();
        //        cmd.Dispose();
        //    }
           
        //   }
    }
}
