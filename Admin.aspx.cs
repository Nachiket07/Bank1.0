using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Bank
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String q1y = "Select count(q1) from [Table] where q1='1'";
            String q1n = "Select count(q1) from [Table] where q1='0'";
            String q1u = "select count(q1) reom [Table] where q1='-1'";

            String q2y = "Select count(q1) from [Table] where q1='1'";
            String q2n = "Select count(q1) from [Table] where q1='0'";
            String q2u = "select count(q1) reom [Table] where q1='-1'";

            String q3y = "Select count(q1) from [Table] where q1='1'";
            String q3n = "Select count(q1) from [Table] where q1='0'";
            String q3u = "select count(q1) reom [Table] where q1='-1'";

            String q4y = "Select count(q1) from [Table] where q1='1'";
            String q4n = "Select count(q1) from [Table] where q1='0'";
            String q4u = "select count(q1) reom [Table] where q1='-1'";

            SqlCommand cmd = new SqlCommand(q1y, con);

        }
    }
}