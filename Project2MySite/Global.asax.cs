using System;
using System.Web;
using WebShopData;


namespace Project2MySite
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["order"] = new Order();
        }//DONE
        protected void Application_BeginRequest(object sender, EventArgs e)//hoppar till denna vid tryck på checkoutknappen
        {

        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }
        protected void Application_Error(object sender, EventArgs e)
        {
            //Kod som körs när ohanterade fel sker
            var ex = Server.GetLastError();
            Application["Exception"] = ex;
            //Skickar vidare till en felsida för att illustrera att ett fel inträffade
            Server.Transfer("Error/ErrorPage.aspx");
            //Vi säger till servern att vi fixade problemet
            Server.ClearError();
        }//DONE
        protected void Session_End(object sender, EventArgs e)
        {
            Session["order"] = null;
        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}