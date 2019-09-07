using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
/*CREATE TABLE [User]
(
	[Phone] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] VARCHAR(50) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL
)
*/
namespace Bank
{
    /* yeah yeah !*/
    public partial class login : System.Web.UI.Page
    {
        public void redirectA(Object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String query = "Select * from [Admin] where Phone='" + Phone.Text + "' AND Password='" + pwd.Text + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                //SqlDataReader q;
                SqlDataReader r = cmd.ExecuteReader();
                Boolean i = r.HasRows;
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Session["Phone"] = r.GetValue(0);
                        Session["Password"] = r.GetValue(1);
                        Session["Name"] = r.GetValue(2);
                        Session["Email"] = r.GetValue(3);
                        //Session["Office"] = r.GetValue(4);
                    }
                    Response.Redirect("~/Admin.aspx");
                }
                else
                {
                    invalid.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            con.Close();
        }
        public void redirectR(Object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
        public void validate(Object sender,EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String query = "Select * from [User] where Phone='" + Phone.Text+"' AND Password='"+pwd.Text+"';";
            SqlCommand cmd = new SqlCommand(query,con);
            try
            {
                //SqlDataReader q;
                SqlDataReader r= cmd.ExecuteReader();
                Boolean i = r.HasRows;
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        Session["Phone"] = r.GetValue(0);
                        Session["Password"] = r.GetValue(1);
                        Session["Name"] = r.GetValue(2);
                        Session["Email"] = r.GetValue(3);
                        //Session["Office"] = r.GetValue(4);
                    }
                    Response.Redirect("~/Welcome1.aspx");
                }
                else
                {
                    invalid.Visible = true;  
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}