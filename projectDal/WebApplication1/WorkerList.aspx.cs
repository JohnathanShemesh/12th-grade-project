using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using projectDal;

namespace WebApplication1
{
    public partial class WorkerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                foreach (DataRow dr in prof.Getprof().Rows)
                {
                    d.Items.Add(new ListItem(dr["TypeProf"].ToString(), dr["IDProf"].ToString()));
                }
            

           
           
        }

        public void d_SelectedIndexChanged(object sender, EventArgs e)
        {
           int index = int.Parse(d.SelectedItem.Value);
           
            this.GridView1.DataSource = Workers.GetWorkerByType(index);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = int.Parse(GridView1.SelectedRow.Cells[5].Text.ToString());
            Session["IDUser"] = x;
            Response.Redirect("RatingPage.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }
    }
}