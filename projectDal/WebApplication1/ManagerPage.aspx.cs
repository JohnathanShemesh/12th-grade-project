using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BL;
using projectDal;

namespace WebApplication1
{
    public partial class ManagerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = Reports.GetReports();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = int.Parse(GridView1.SelectedRow.Cells[1].Text.ToString());
            WorkCallProf.Delete(x);
            WorkCall.Delete(x);
           
        }
    }
}