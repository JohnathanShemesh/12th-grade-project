using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.ServiceReference1;
using projectDal;
using System.Data;
namespace WebApplication2
{
    public partial class WebService : System.Web.UI.Page
    {
        ServiceReference1.Service1Client s = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            s.Add(Calendar1.SelectedDate.ToString("yyyy/MM/dd"), detailsText.Text);
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}