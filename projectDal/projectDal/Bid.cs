using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDal
{
   public class Bid
    {
        public static void Add(int IDCall, int BidPrice, string BidDetails,string BidDate, bool IsAccepted)
        {
            string s = $"INSERT INTO Bid(IDCall,BidPrice,BidDetails,BidDate,IsAccepted) VALUES ({IDCall},{BidPrice},'{BidDetails}','{BidDate}',{IsAccepted})";
            oledbhelper.Execute(s);
        }
        public static DataTable GetBid(string IDBid)
        {
            string s = $"SELECT * FROM Bid WHERE IDBid='{IDBid}'";
            return oledbhelper.GetTable(s);
        }
       
        public static void Delete(int IDCall)
        {
            string s = $"DELETE FROM Bid WHERE IDcall = {IDCall}";
            oledbhelper.Execute(s);
        }
        public static void Update(string BidDate)
        {
            string s = $"UPDATE Bid SET BidDate = '{BidDate}'";
            oledbhelper.Execute(s);
        }
    }
}
