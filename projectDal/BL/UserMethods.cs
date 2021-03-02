using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectDal;
using System.Data;

namespace BL
{
   public class UserMethods
    {

        public static UserType Login(string email,string Password)
        {
           int userType = Users.IsUserExist(email, Password);
            switch (userType)
            {
                case 1: return UserType.user;
                case 2: return UserType.worker;
                case 3: return UserType.manager;
                case 4: return UserType.none;
               
                default: return UserType.none;
            
            }

        }
        public static void RegisterUser(string fulllname,string email,string password,bool ismanager)
        {
            Users.Add(email, fulllname, password, ismanager);
        }
        public static void AddWorker(string description, int expirience, int iduser,string location)
        {
            Workers.Add(description, expirience, iduser, location);
        }
        public static void SetRating(int idworker)
        {
            Rating.GetRatingAvg(idworker);
        }
       
    }

    public enum UserType
    {
        none,
        user,
        worker,
        manager
    }
}
