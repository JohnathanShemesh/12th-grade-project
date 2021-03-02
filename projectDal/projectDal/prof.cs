using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
  public  class prof
    {
        public static DataTable Getprof(int IDProf)
        {
            string s = $"SELECT * FROM Prof WHERE IDProf = {IDProf}";
            return oledbhelper.GetTable(s);
        }
        public static DataTable Getprof()
        {
            string s = $"SELECT * FROM Prof ";
            return oledbhelper.GetTable(s);
        }
    }
}
