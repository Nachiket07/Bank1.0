using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Bank
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void register(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String query = "Select count(*) from [User] where Phone='" +phone.Text +"'";
            SqlCommand cmd = new SqlCommand(query,con);
            int i=(Int32)cmd.ExecuteScalar();
            if (i == 0)
            {
                query = "INSERT INTO [User] VALUES(@Phone,@Password,@Name,@Email,-2)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("login.aspx");
            }
            else
            {
                rejected.Visible = true;
            }
            con.Close();
        }
    }
}