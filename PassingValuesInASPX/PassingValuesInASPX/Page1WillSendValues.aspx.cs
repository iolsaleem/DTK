using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PassingValuesInASPX
{
    public partial class Page1WillSendValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void BtnResponseRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2WillRecieveValues.aspx?id=1&Name="+TxtName.Text, false);
        }

        protected void BtnSessionVariable_Click(object sender, EventArgs e)
        {
            Session["Name"] = TxtName.Text;
            Response.Redirect("Page2WillRecieveValues.aspx");
        }

        protected void BtnCookies_Click(object sender, EventArgs e)
        {
            HttpCookie cKie = new HttpCookie("Name");
            cKie.Value = TxtName.Text;
            Response.Cookies.Add(cKie);
            Response.Redirect("Page2WillRecieveValues.aspx");
        }

        protected void BtnApplicationState_Click(object sender, EventArgs e)
        {
            Application["Name"] = TxtName.Text;
            Response.Redirect("Page2WillRecieveValues.aspx");
        }



        public string getName
        {
            get
            {
                return TxtName.Text;
            }
        }

        protected void BtnHTTPCONTEXT_Click(object sender, EventArgs e)
        {
            Server.Transfer("Page2WillRecieveValues.aspx");
        }
         
    }
}