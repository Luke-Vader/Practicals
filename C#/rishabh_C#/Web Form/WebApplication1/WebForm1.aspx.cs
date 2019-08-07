using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-R031P94\SQLEXPRESS;Integrated Security=True");
            sql.Open();
            string sqlQuery = "insert into employee_details values(@t1,@t2,@t3,@t4)";
            SqlCommand command = new SqlCommand(sqlQuery, sql);
            command.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            command.Parameters.AddWithValue("@t2", TextBox2.Text);
            command.Parameters.AddWithValue("@t3", int.Parse(TextBox3.Text));
            command.Parameters.AddWithValue("@t4", TextBox4.Text);
            command.ExecuteNonQuery();
            sql.Close();

        }
    }
}