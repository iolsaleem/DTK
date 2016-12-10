using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PassingValuesInASPX
{
    public partial class Page2WillRecieveValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //values Passing using Response.Redirect
            string id = Request.QueryString["id"];
            //Hello

           if(id!=null)
           {
                if (id == "1")
                {
                    Response.Write("values Passing using Response.Redirect");
                    if (Request.QueryString["Name"] != null)
                       {
                       LblResponseRedirect.Text = Request.QueryString["Name"];
                       }
                }
           }


           //Values passing using Cookies---Cookies are created on the server side 
            //but saved on the client side.

        if(Request.Cookies["Name"]!=null)
        {
            Response.Write("values Passing using Cookies");
            LabelCookies.Text = Request.Cookies["Name"].Value;
        }


            //Values Passed using Session--session variables which are handled by the server.
            //Sessions are created as soon as the first response is being sent 
            //from the client to the server, 
            //and session ends when the user closes his browser window 
            //or some abnormal operation takes place.

        if(Session["Name"]!=null)
        {
            Response.Write("values Passing using Cookies");
            LabelSession.Text = Session["Name"].ToString(); 

        }
            //Values passign using Application Variables
            //Sometimes, we need to access a value from anywhere in our page. 
            //For that, you can use Application variables. 

            if(Application["Name"]!=null)
            {
                Response.Write("values passing using Application");
                LabelApplication.Text = Application["Name"].ToString();

            }


            //You can also use HttpContext to retrieve values from pages. The values are retrieved using properties or methods. 
            //It's a good idea to use properties since they are easier to code and modify. 
            //In your first page, make a property that returns the value of the TextBox.
       //     Page1WillSendValues Pg;

      //      Pg = (Page1WillSendValues)Context.Handler;

     //       LabelHttpContext.Text = Pg.getName;


        }
    }
}