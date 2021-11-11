using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data;
using DAL;
using Model;


namespace BLL
{
    public class BillPrintBLL
    {
        BillPrintDAL billPrintDAL;

        public void SaveControl(List<MyControl> controls)
        {
            billPrintDAL = new BillPrintDAL();
            billPrintDAL.SaveControl(controls);
        }


        public DataTable ReadControl()
        {
            billPrintDAL = new BillPrintDAL();
            return billPrintDAL.ReadControl();
        }
    }
}
