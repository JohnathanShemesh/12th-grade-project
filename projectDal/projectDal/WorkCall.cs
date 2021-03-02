using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
   public class WorkCall
    {
        public static void Add(string datecall, int iduser, string details)
        {
            string s = $"INSERT INTO WorkCall (DateCall,IDUser,Details) VALUES ('{datecall}',{iduser},'{details}')";
            oledbhelper.Execute(s);
        }
        public static void Add(string datecall, string details)
        {
            string s = $"INSERT INTO WorkCall (DateCall,IDUser,Details) VALUES ('{datecall}',{40},'{details}')";
            oledbhelper.Execute(s);
        }
        public static DataTable GetWorkCall(int idcall,int iduser)
        {
            string s = $"SELECT * FROM WorkCall WHERE IDCall={idcall} AND  IDUser = {iduser}";
            return oledbhelper.GetTable(s);
        }
        public static void MakeInactive (int idcall, bool activity)
        {
            string s = $"UPDATE WorkCall SET IsActive = {activity} WHERE IDCall = {idcall}";
            oledbhelper.Execute(s);
        }
        public static int GetWorkerID(int idcall)
        {
            string s = $"SELECT IDWorker FROM WorkCall WHERE IDCall; = {idcall}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDCall"].ToString());
            }
            return -1;
        }
        public static DataTable GetWorkCall( int iduser)
        {
            string s = $"SELECT * FROM WorkCall WHERE IDUser = {iduser}";
            return oledbhelper.GetTable(s);
        }
        public static DataTable GetActiveWorkCall(int iduser)
        {
            string s = $"SELECT * FROM WorkCall WHERE IDUser = {iduser} AND IsActive = true";
            return oledbhelper.GetTable(s);
        }
        public static DataTable GetAllWorkCall()
        {
            string s = $"SELECT * FROM WorkCall WHERE ";
            return oledbhelper.GetTable(s);
        }
        public static void Delete(int idcall,int iduser)
        {
            string s = $"DELETE FROM WorkCall WHERE IDCall = {idcall} AND IDUser = {iduser}";
            oledbhelper.Execute(s);
        }
        public static void Delete(int idcall)
        {
            string s = $"DELETE FROM WorkCall WHERE IDCall = {idcall} ";
            oledbhelper.Execute(s);
        }
        public static void Update(int iduser, int datecall)
        {
            string s = $"UPDATE WorkCall SET DateCall ={datecall} WHERE IDUser = {iduser}";
            oledbhelper.Execute(s);
        }
        public static int GetLastId()
        {
            string s = $"SELECT WorkCall.IDCall FROM WorkCall ORDER BY WorkCall.IDCall DESC;";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDCall"].ToString());
            }
            else
            {
                return -1;
            }
        }
        public static DataTable GetWorkcallByProf(int IDProf)
        {
            string s = $"SELECT WorkCallProf.IDCall, WorkCallProf.IDProf, WorkCall.DateCall, WorkCall.Details FROM WorkCall INNER JOIN WorkCallProf ON WorkCall.IDCall = WorkCallProf.IDCall WHERE(WorkCallProf.IDProf) ={IDProf} ORDER BY WorkCall.DateCall DESC";
            return oledbhelper.GetTable(s);
            
        }
    }
}
