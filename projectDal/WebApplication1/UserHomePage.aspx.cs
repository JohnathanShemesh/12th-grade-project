using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using projectDal;


namespace WebApplication1
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["id"] != null)
            {
                string fname = Users.GetUserFullName(int.Parse(Cache["id"].ToString()));
                Label1.Text = "Hello " + fname;
            }
            if (!this.IsPostBack)
            {
                if (Cache["id"] != null)
                {
                    GridView1.DataSource = WorkCall.GetActiveWorkCall(int.Parse(Cache["id"].ToString()));
                    GridView1.DataBind();
                   
                }   
                else
                {
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserPage.aspx");
        }

       

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         int x =  int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());           
            int y = GridView1.SelectedRow.RowIndex;
            WorkCall.MakeInactive(x, false);
            RateButton.Visible = true;
            RateButton.Enabled = true;
            NoButton.Visible = true;
            NoButton.Enabled = true;
            RateLabel.Visible = true;
            
           
        }

        protected void RateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkerList.aspx");
        }

        protected void NoButton_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = WorkCall.GetActiveWorkCall(int.Parse(Cache["id"].ToString()));
            GridView1.DataBind();
            RateButton.Visible = false;
            RateButton.Enabled = false;
            NoButton.Visible = false;
            NoButton.Enabled = false;
            RateLabel.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkerList.aspx");
        }
    }
}