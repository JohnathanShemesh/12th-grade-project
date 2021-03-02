using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Data;
using BL;
using projectDal;
using System.Data;
using System.Data.OleDb;


namespace WebApplication1
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["id"]!=null)
            {
               string fname =Users.GetUserFullName(int.Parse(Cache["id"].ToString()));
                Label2.Text = "Hello " + fname;
            }
            if (!IsPostBack)
            {
                foreach (DataRow dr in prof.Getprof().Rows)
                {
                    c.Items.Add(new ListItem(dr["TypeProf"].ToString(), dr["IDProf"].ToString()));
                }
            }
        }

        protected void AddCallButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < c.Items.Count; i++)
            {

                if (c.Items[i].Selected)
                {

                    

                }

            }
            WorkCallMethods.AddCall(WorkCallMethods.GetDate(Calendar1.SelectedDate),detailsText.Text,int.Parse(Cache["id"].ToString()));
            Label5.Visible = true;
            int x = c.SelectedIndex;
            foreach (ListItem li in c.Items)
            {
                if (li.Selected == true)
                {
                    WorkCallProf.Add(WorkCall.GetLastId(),int.Parse(li.Value));
                }
            }
          
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomePage.aspx");
        }
    }
}