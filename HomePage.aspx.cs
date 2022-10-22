using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["accountNumberObt"] == null)
            {
                   Response.Write("Error");
            }
        }

        protected void Click_PerformTransaction(object sender, EventArgs e)
        {
            Response.Redirect("PerformTransaction.aspx");
        }

        protected void Click_TransactionShow(object sender, EventArgs e)
        {
            Response.Redirect("Transaction_crud1.aspx");
        }

        protected void Click_MyBalance(object sender, EventArgs e)
        {
            Response.Redirect("CheckBalance.aspx");
        }

        protected void Click_MyCredit(object sender, EventArgs e)
        {
            Response.Redirect("CreditHistroy.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Logout.aspx");
            Session.Remove("accountNumberObt");
            Session.RemoveAll();
            Response.Redirect("/Home1.aspx");
        }
    }
}