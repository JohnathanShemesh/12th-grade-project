using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using WebApplication1.Data;
using projectDal;
namespace WebApplication1
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Password.Text = "123123123";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserType type = UserMethods.Login(Email.Text, Password.Text);
            Global.Email = Email.Text;
            Global.UserType = type;
            Cache["id"] = Users.GetUserId(Email.Text, Password.Text);
            Session["IDWorker"] = Workers.GetIDWorker(Users.GetUserId(Email.Text,Password.Text));
            switch (type)
            {
                case UserType.none:
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('User not found')", true);
                    break;
                case UserType.user:                   
                    Response.Redirect("UserHomePage.aspx");
                    break;
                case UserType.worker:
                    Response.Redirect("WorkerPage.aspx");
                    break;
                case UserType.manager:
                    Response.Redirect("ManagerPage.aspx");
                    break;
            }

        }
    }
}