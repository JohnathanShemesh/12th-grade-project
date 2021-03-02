using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
	public class Users
	{
        public static void Add(string emailUser, string FullName, string PasswordUser, bool IsManager)
        {
            string s = $"INSERT INTO Users(emailUser,FullName,PasswordUser,IsManager) VALUES ('{emailUser}','{FullName}','{PasswordUser}',{IsManager})";
            oledbhelper.Execute(s);
        }
        public static DataTable GetUser(string email,string password)
        {
            string s = $"SELECT * FROM Users WHERE emailUser='{email}' AND  PasswordUser = '{password}'";
            return oledbhelper.GetTable(s);
        }
        public static DataTable GetUser()
        {
            string s = $"SELECT * FROM Users ";
            return oledbhelper.GetTable(s);
        }

        public static int GetUserId(string email, string password)
        {
            string s = $"SELECT IDUser FROM Users WHERE emailUser='{email}' AND  PasswordUser = '{password}'";
            DataTable dt= oledbhelper.GetTable(s);
            if (dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDUser"].ToString());
            }
            return -1; 
        }
        public static int GetUserID(string email, string password)
        {
            string s = $"SELECT * FROM Users WHERE emailUser='{email}' AND  PasswordUser = '{password}'";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["IDUser"].ToString());
            }
            return -1;
        }
        public static string GetUserFullName(int id)
        {
            string s = $"SELECT * FROM Users WHERE IDUser = {id}";
            DataTable dt = oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr["FullName"].ToString();
            }
            return "not found";
        }

        public static DataTable GetUser(string email)
        {
            string s = $"SELECT * FROM Users WHERE emailUser='{email}'";
            return oledbhelper.GetTable(s);
        }
        public static void Delete(int IDUser)
        {
            string s = $"DELETE FROM Users WHERE IDUser = {IDUser}";
            oledbhelper.Execute(s);
        }
        public static void Update(string email,string password)
        {
            string s = $"UPDATE Users SET PasswordUser='{password}' WHERE emailUser = '{email}'";
            oledbhelper.Execute(s);
        }
        public static int IsUserExist(string email, string password)
        {
            string s = $"SELECT * FROM Users WHERE emailUser='{email}' AND  PasswordUser = '{password}'";
           
            DataTable dt =  oledbhelper.GetTable(s);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
               string st =  dr["isManager"].ToString();
                string st1 = dr["isBigManager"].ToString();
                if (st == "True")
                {
                    return 2;
                    // 1= user 2 = worker 3 = not found
                }
                if (st1 == "True")
                {
                    return 3;
                    // 1= user 2 = worker 3 = not found
                }
                else
                    return 1;
            }
                
                    
                else
                    return 4;
               
           
           
        }
    }
}
