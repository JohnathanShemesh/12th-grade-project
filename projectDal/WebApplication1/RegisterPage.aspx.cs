using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using System.Data;
using projectDal;
namespace WebApplication1
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserMethods.RegisterUser(FullName.Text, Email.Text, Password.Text, CheckBox1.Checked);
            Cache["id"] = Users.GetUserId(Email.Text, Password.Text);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You are registered')", true);
            if (CheckBox1.Checked == true)
            {

                Response.Redirect("WorkerRegister.aspx");
            }
            Response.Redirect("UserHomePage.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}