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
    protected void TextBox12_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        con.ConnectionString = "Data Source=.;Initial Catalog=CimaExam;Integrated Security=True";
        com.Connection = con;

        con.Open();

        com.CommandText = "INSERT INTO studentNew VALUES (@cima_id,@cimareg_Date,@F_Name ,@M_Name,@L_Name,@National_id,@email,@telephone_Num,@AddlressL1,@AddlressL2,@AddlressL3,@gender,@DOB,@nationality)";
        com.Parameters.AddWithValue("cima_id", TextBox1.Text);
        com.Parameters.AddWithValue("cimareg_Date", TextBox2.Text);
        com.Parameters.AddWithValue("F_Name", TextBox3.Text);
        com.Parameters.AddWithValue("M_Name", TextBox4.Text);
        com.Parameters.AddWithValue("L_Name", TextBox5.Text);
        com.Parameters.AddWithValue("National_id", TextBox6.Text);
        com.Parameters.AddWithValue("email", TextBox7.Text);
        com.Parameters.AddWithValue("telephone_Num", TextBox8.Text);
        com.Parameters.AddWithValue("AddlressL1", TextBox9.Text);
        com.Parameters.AddWithValue("AddlressL2", TextBox10.Text);
        com.Parameters.AddWithValue("AddlressL3", TextBox11.Text);
        com.Parameters.AddWithValue("gender", DropDownList1.SelectedItem.ToString());
        com.Parameters.AddWithValue("DOB", TextBox12.Text);
        com.Parameters.AddWithValue("nationality", DropDownList2.SelectedItem.ToString());
        com.ExecuteNonQuery();

        Label16.Visible = true;


        con.Close();


    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReportFinal.aspx");
    }
}