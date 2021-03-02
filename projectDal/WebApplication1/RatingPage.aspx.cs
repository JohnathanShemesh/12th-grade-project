using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;
using projectDal;
using System.Data;

namespace WebApplication1
{
    public partial class RatingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void star1_Click(object sender, ImageClickEventArgs e)
        {
            Cache["rate"] = 1;
            star1.ImageUrl = "Resources/star.png";
            star2.ImageUrl = "Resources/hollowstar.png";
            star3.ImageUrl = "Resources/hollowstar.png";
            star4.ImageUrl = "Resources/hollowstar.png";
            star5.ImageUrl = "Resources/hollowstar.png";
        }

        protected void star2_Click(object sender, ImageClickEventArgs e)
        {
            Cache["rate"] = 2;

            star1.ImageUrl = "Resources/star.png";
            star2.ImageUrl = "Resources/star.png";
            star3.ImageUrl = "Resources/hollowstar.png";
            star4.ImageUrl = "Resources/hollowstar.png";
            star5.ImageUrl = "Resources/hollowstar.png";
        }

        protected void star3_Click(object sender, ImageClickEventArgs e)
        {
            Cache["rate"] = 3;

            star1.ImageUrl = "Resources/star.png";
            star2.ImageUrl = "Resources/star.png";
            star3.ImageUrl = "Resources/star.png";
            star4.ImageUrl = "Resources/hollowstar.png";
            star5.ImageUrl = "Resources/hollowstar.png";
        }

        protected void star4_Click(object sender, ImageClickEventArgs e)
        {
            Cache["rate"] = 4;

            star1.ImageUrl = "Resources/star.png";
            star2.ImageUrl = "Resources/star.png";
            star3.ImageUrl = "Resources/star.png";
            star4.ImageUrl = "Resources/star.png";
            star5.ImageUrl = "Resources/hollowstar.png";
        }

        protected void star5_Click(object sender, ImageClickEventArgs e)
        {
            Cache["rate"] = 5;
            star1.ImageUrl = "Resources/star.png";
            star2.ImageUrl = "Resources/star.png";
            star3.ImageUrl = "Resources/star.png";
            star4.ImageUrl = "Resources/star.png";
            star5.ImageUrl = "Resources/star.png";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int idworker = Workers.GetIDWorker(int.Parse(Session["IDUser"].ToString()));
            Rating.Add(idworker, int.Parse(Cache["rate"].ToString()), TextBox1.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomepage.aspx");
        }
    }
}