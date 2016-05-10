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
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {
            }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox15.Text = Calendar2.SelectedDate.ToString("dd/MM/yyyy");
        Calendar2.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try { 
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        con.ConnectionString = "Data Source=.;Initial Catalog=CimaExam;Integrated Security=True";
        com.Connection = con;

       

        com.CommandText = "INSERT INTO Register VALUES (@module_id,@Module_name,@exam_date,@computer,@admin_id,@reg_date,@Bslip_no,@Bank_name ,@Bank_Location,@paid_date,@cima2_id_fk )";
        com.Parameters.AddWithValue("module_id", DropDownList3.SelectedItem.ToString());
        com.Parameters.AddWithValue("Module_name", DropDownList4.SelectedItem.ToString());
        com.Parameters.AddWithValue("exam_date", TextBox15.Text);
        com.Parameters.AddWithValue("computer", TextBox14.Text);
        com.Parameters.AddWithValue("admin_id", TextBox17.Text);
        com.Parameters.AddWithValue("reg_date", TextBox3.Text);
        com.Parameters.AddWithValue("Bslip_no", TextBox2.Text);
        com.Parameters.AddWithValue("Bank_name", TextBox4.Text);
        com.Parameters.AddWithValue("Bank_Location", TextBox5.Text);
        com.Parameters.AddWithValue("paid_date", TextBox6.Text);
        com.Parameters.AddWithValue("cima2_id_fk", TextBox1.Text);


        con.Open();
 
        com.ExecuteNonQuery();



        con.Close();
        }
        catch (Exception ex)
        {

            Response.Write("Error" + ex.ToString());


        }
    }
}