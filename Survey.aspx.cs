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
    public partial class Survey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void submitClick(object sender, EventArgs e)
        {
            String no = "-1";
            String i=  a.SelectedValue;
            String j = b.SelectedValue;
            String k = c.SelectedValue;
            String l = d.SelectedValue;
            if (i.Equals(""))
            {
                i = no;
            }
            if (j.Equals(""))
            {
                j = no;
            }
            if (k.Equals(""))
            {
                k = no;
            }
            if (l.Equals(""))
            {
                l = no;
            }
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banks"].ConnectionString);
            con.Open();
            String query = "Insert Into [Table] values(@w,@x,@y,@z)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@w",i);
            cmd.Parameters.AddWithValue("@x",j);
            cmd.Parameters.AddWithValue("@y",k);
            cmd.Parameters.AddWithValue("@z", l);
            /*int res = (Int32)*/cmd.ExecuteScalar();
            //Console.WriteLine(res);
            con.Close();
            Session.Abandon();
            Response.Redirect("login.aspx");
            //Response.Write(i+j+k+l);
            

        }
    }
}