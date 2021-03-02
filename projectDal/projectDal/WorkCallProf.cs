using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
    public class WorkCallProf
    {
        public static void Add(int IDCall,int IDProf)
        {
            string s = $"INSERT INTO WorkCallProf (IDCall,IDProf) VALUES ({IDCall},{IDProf})";
            oledbhelper.Execute(s);
        }
        public static void Delete(int IDCall)
        {
            string s = $"DELETE FROM WorkCallProf WHERE IDcall = {IDCall}";
            oledbhelper.Execute(s);
        }
    }
}
