using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class SuccesfulTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Your Transaction had Successfull");
        }

        protected void Click_TransactionShow(object sender, EventArgs e)
        {
            Response.Redirect("Transaction_crud1.aspx");
        }

        protected void Click_MyBalance(object sender, EventArgs e)
        {
            Response.Redirect("CheckBalance.aspx");
        }

        protected void Click_GoHome(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}