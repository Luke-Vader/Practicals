using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication13
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand cmd;
        String sqlstr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=XKC-75\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            sqlstr = "insert into emp values (@t1,@t2,@t3,@t4)";
            cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@t3", int.Parse(TextBox3.Text));
            cmd.Parameters.AddWithValue("@t4", int.Parse(TextBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "data added";
            string s = "select * from emp";
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(s, con);
                adapt.Fill(ds);
                con.Close();
                GridView2.Visible = true;
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=XKC-75\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            sqlstr = "delete emp where enpno=@t1";
            cmd = new SqlCommand(sqlstr, con);
        
            cmd.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "data deleted";

            string s = "select * from emp";
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(s, con);
                adapt.Fill(ds);
                con.Close();
                GridView2.Visible = true;
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=XKC-75\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            string sqlstr = "select * from emp where enpno=@t1";
            SqlCommand myCommand = new SqlCommand(sqlstr, con);
            myCommand.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            using (con)
            {
                SqlDataReader rs = myCommand.ExecuteReader();
                while (rs.Read())
                {
                    TextBox1.Text = (rs["enpno"].ToString());
                    TextBox2.Text = (rs["name"].ToString());
                    TextBox3.Text = (rs["age"].ToString());
                    TextBox4.Text = (rs["sal"].ToString());
                }
                con.Close();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=XKC-75\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            con.Open();
            sqlstr = "update emp set name=@t2,age=@t3,sal=@t4 where enpno=@t1";
            cmd = new SqlCommand(sqlstr, con);
            cmd.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@t3", int.Parse(TextBox3.Text));
            cmd.Parameters.AddWithValue("@t4", int.Parse(TextBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "data updated";
            string s = "select * from emp";
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(s, con);
                adapt.Fill(ds);
                con.Close();
                GridView2.Visible = true;
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
