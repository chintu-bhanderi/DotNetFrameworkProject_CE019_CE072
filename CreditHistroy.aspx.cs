using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BankingApplication
{
    public partial class CreditHistroy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myAccount = (Session["accountNumberObt"]).ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-FL1EIHNK;Integrated Security=True;Initial Catalog=Test";
            try
            {
                using (con)
                {
                    string commnad = "Select [My Account],[Payee Name],[Amount],[Remark] from [dbo].[Transaction1] where [To Account]=@myAccount";
                    SqlCommand cmd = new SqlCommand(commnad, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@myAccount", myAccount);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewCredit.DataSource = rdr;
                    GridViewCredit.DataBind();
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }
    }
}