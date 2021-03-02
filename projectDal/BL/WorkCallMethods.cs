using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectDal;

namespace BL
{
  public  class WorkCallMethods
    {
        public static string GetDate(DateTime d)
        {
            string sd = d.Date.ToString("yyyy/MM/dd");
            return sd;
        }
        public static void AddCall(string callDate, string details, int iduser)
        {
            WorkCall.Add(callDate, iduser, details);
        }
        public static void AddCall(string email,string details,List<int> profsid)
        {
            DataTable dt =  Users.GetUser(email);
            int id = int.Parse(dt.Rows[0]["IDUser"].ToString());
            WorkCall.Add(DateTime.Now.ToString(), id, details);
        }
    }
}
