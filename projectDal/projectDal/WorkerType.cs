using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projectDal
{
   public class WorkerType
    {
        public static void Add(int IDWorker,int IDProf)
        {
            string s = $"INSERT INTO WorkerType(IDWorker,IDProf) VALUES ({IDWorker},{IDProf})";
            oledbhelper.Execute(s);
        }
        public static int GetProfById(int IDWorker)
        {
            string s = $"SELECT IDProf FROM WorkerType WHERE IDWorker = {IDWorker}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDProf"].ToString());
            }
            return -1;
        }
    }
}
