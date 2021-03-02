using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
  public class Workers
    {
        public static void Add(string Description, int Expirience, int IDUser, string LocationWorker)
        {
            string s = $"INSERT INTO Workers([Description],Expirience,IDUser,LocationWorker) VALUES ('{Description}',{Expirience},{IDUser},'{LocationWorker}')";
            oledbhelper.Execute(s);
        }
        public static DataTable GetWorker(int IDUser)
        {
            string s = $"SELECT * FROM Workers WHERE IDUser = {IDUser}";
            return oledbhelper.GetTable(s);
        }
        public static DataTable GetWorkers()
        {
            string s = $"SELECT Workers.IDWorker, Users.FullName, Avg(Ratings.WorkerRating) AS AVGRating, Users.IDUser FROM(Users INNER JOIN Workers ON Users.IDUser = Workers.IDUser) INNER JOIN Ratings ON Workers.IDWorker = Ratings.IDWorker GROUP BY Workers.IDWorker, Users.FullName, Users.IDUser";            
            return oledbhelper.GetTable(s);
        }
        public static void Delete(int IDWorker)
        {
            string s = $"DELETE FROM Workers WHERE IDWorker = {IDWorker}";
            oledbhelper.Execute(s);
        }
        public static void Update(string LocationWorker)
        {
            string s = $"UPDATE Workers SET LocationWorker = '{LocationWorker}'";
            oledbhelper.Execute(s);
           
    }
        public static DataTable GetWorkerByType(int WorkerType)
        {
            string s = "SELECT Workers.IDWorker, Users.FullName, Avg(Ratings.WorkerRating) AS AvgמתוךWorkerRating, WorkerType.IDProf, Users.IDUser FROM((Users INNER JOIN Workers ON Users.IDUser = Workers.IDUser) LEFT JOIN Ratings ON Workers.IDWorker = Ratings.IDWorker) INNER JOIN WorkerType ON Workers.IDWorker = WorkerType.IDWorker GROUP BY Workers.IDWorker, Users.FullName, WorkerType.IDProf, Users.IDUser HAVING WorkerType.IDProf =" + WorkerType;

            return oledbhelper.GetTable(s);
        }
        public static DataTable GetWorker()
        {
            string s = "SELECT Users.FullName, Prof.TypeProf, Users.emailUser, Prof.IDProf, Users.IDUser FROM(Users INNER JOIN Workers ON Users.IDUser = Workers.IDUser) INNER JOIN (Prof INNER JOIN WorkerType ON Prof.IDProf = WorkerType.IDProf) ON Workers.IDWorker = WorkerType.IDWorker";

            return oledbhelper.GetTable(s);
        }
        public static int GetIDWorker(int iduser)
        {
            string s = $"SELECT IDWorker FROM Workers WHERE IDUser = {iduser}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDWorker"].ToString());
            }
            return -1;
        }
        
    }
}
