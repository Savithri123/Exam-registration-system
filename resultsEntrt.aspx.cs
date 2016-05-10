using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)

    {
        try
        {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            con.ConnectionString = "Data Source=.;Initial Catalog=CimaExam;Integrated Security=True";
            com.Connection = con;

            con.Open();

            com.CommandText = "INSERT INTO results VALUES (@res_no,@result_date,@marks ,@conclusion,@admin_id,@i_id)";
            com.Parameters.AddWithValue("res_no", TextBox3.Text);
            com.Parameters.AddWithValue("result_date", TextBox2.Text);
            com.Parameters.AddWithValue("marks", TextBox5.Text);
            com.Parameters.AddWithValue("conclusion", TextBox6.Text);
            com.Parameters.AddWithValue("admin_id", TextBox4.Text);
            com.Parameters.AddWithValue("i_id", TextBox1.Text);

            com.ExecuteNonQuery();



            con.Close();
        }
        catch (Exception ex)
        {

            Response.Write("Error" + ex.ToString());


        }

    }
}