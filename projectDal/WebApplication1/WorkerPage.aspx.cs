using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using projectDal;
using System.Data.OleDb;

namespace WebApplication1
{
    public partial class WorkerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["id"] != null)
            {
                string fname = Users.GetUserFullName(int.Parse(Cache["id"].ToString()));
                Label1.Text = "Hello " + fname;
            }
            int x = WorkerType.GetProfById(int.Parse(Session["IDWorker"].ToString()));
            GridView1.DataSource = WorkCall.GetWorkcallByProf(x);
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           int x = int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());
            Session["x"] = x;
            Label2.Visible = true;
            Button1.Visible = true;
            TextBox1.Visible = true;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Reports.Add(int.Parse(Session["x"].ToString()), TextBox1.Text);
        }
    }
}