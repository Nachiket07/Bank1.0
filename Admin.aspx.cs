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
        SqlConnection questions=null;
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["Name"] != null)
            {
                welcome.Text = Session["Name"].ToString();
            }
            else
            {
                Response.Redirect("login.aspx");
            }*/
            questions = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            questions.Open();
            String query = "Select * from [Questions]";
            SqlCommand cmd = new SqlCommand(query, questions);
            //cmd.ExecuteReader();
            try
            {
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    count = r.GetInt32(1);
                }
                r.Close();
                count += 1;
            }
            catch(Exception ex) {
                Response.Write(ex);
            }
            /*String query = "INSERT INTO Questions VALUES('"+question.Text+"')";
            SqlCommand cmd = new SqlCommand(query, questions);
            cmd.ExecuteNonQuery();*/
            
            /*SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            
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
            
            SqlCommand cmd = new SqlCommand(q1y, con);*/

        }
        public void Adder(object sender, EventArgs e)
        {
            
            String query = "INSERT INTO [Questions] VALUES('"+ question.Text + "'," + count + ")";
            SqlCommand cmd = new SqlCommand(query, questions);
            cmd.ExecuteNonQuery();
            count += 1;
        }

        public void Deleter(object sender, EventArgs e)
        {
            String query = "Delete from [Questions] where Id="+dquestion.Text;
            SqlCommand cmd = new SqlCommand(query, questions);
            cmd.ExecuteNonQuery();
        }

        public void logouter(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            if(question!=null)
                questions.Close();
        }
    }
}