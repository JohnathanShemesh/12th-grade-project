using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using projectDal;


namespace projectDal
{
   public class Reports
    {
        public static void Add(int idcall, string comment)
        {
            string s = $"INSERT INTO Reports (IDCall,comment) VALUES ({idcall},'{comment}')";
            oledbhelper.Execute(s);
        }
        public static DataTable GetReports()
        {
            string s = $"SELECT Reports.IDCall, Reports.Comment, Reports.Status, WorkCall.DateCall, WorkCall.Details FROM WorkCall INNER JOIN Reports ON WorkCall.IDCall = Reports.IDCall WHERE Reports.Status = 1";
            return oledbhelper.GetTable(s);
        }
    }
}
