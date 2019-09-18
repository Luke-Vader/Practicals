using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication7
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=XKC-87\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();

            string sqlstr = "insert into sunjanak values(@t1,@t2,@t3,@t4)";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@t3", int.Parse(TextBox3.Text));
            cmd.Parameters.AddWithValue("@t4", TextBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data Added";
        }
    }
}
