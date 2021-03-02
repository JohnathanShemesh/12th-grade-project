using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using projectDal;
using BL;

namespace WebApplication1
{
    public partial class WorkerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (DataRow dr in prof.Getprof().Rows)
                {
                    CheckBoxList1.Items.Add(new ListItem(dr["TypeProf"].ToString(), dr["IDProf"].ToString()));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int x = int.Parse(Cache["id"].ToString());
            UserMethods.AddWorker(desText.Text, int.Parse(xpText.Text),x,locText.Text);
            int y = Workers.GetIDWorker(int.Parse(Cache["id"].ToString()));
            int z = int.Parse(CheckBoxList1.SelectedValue);
            WorkerType.Add(y,z);
            Session["IDWorker"] = y;

            Response.Redirect("WorkerPage.aspx");
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}