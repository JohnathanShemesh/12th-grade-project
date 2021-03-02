using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
   public class Rating
    {
        public static void Add(int idworker,int workerrating,string workcomment)
        {
            string s = $"INSERT INTO Ratings (IDWorker,WorkerRating,WorkComment) VALUES ({idworker},{workerrating},'{workcomment}')";
            oledbhelper.Execute(s);
        }
        public static DataTable GetRating(int idworker,int iduser)
        {
            string s = $"SELECT * FROM Ratings WHERE IDWorker={idworker} AND  IDUser = {iduser}";
            return oledbhelper.GetTable(s);
        }
        public static void Delete(int idrating)
        {
            string s = $"DELETE FROM Ratings WHERE IDRating = {idrating}";
            oledbhelper.Execute(s);
        }
        public static void Update(int workerrating,int idrating)
        {
            string s = $"UPDATE Ratings SET WorkerRating={workerrating} WHERE IDRating = {idrating}";
            oledbhelper.Execute(s);

        }
        public static int GetCount(int idworker)
        {
            string s = $"SELECT pCount FROM Ratings WHERE IDWorker={idworker}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["pCount"].ToString());
            }
            return -1;
        }
        public static int GetRatingAvg(int IDWorker)
        {
            string s = $"SELECT Ratings.IDWorker, Avg(Ratings.WorkerRating) AS RatingAvg FROM Ratings GROUP BY Ratings.IDWorker HAVING Ratings.IDWorker = {IDWorker}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["RatingAvg"].ToString());
            }
            return -1;

        }
    }
}
