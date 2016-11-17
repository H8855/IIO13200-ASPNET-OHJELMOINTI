using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PotentialInjectionRisk : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
        if (!IsPostBack)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
  }

    protected void btnAddToMySQL_Click(object sender, EventArgs e)
    {
        //kantaan ilman sanitointia
        string nimi = txtName.Text;
        string kommentti = txtComment.Text;
        string pvm = txtDate.Text;
        //string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES ('{0}', '{1}', '{2}');", nimi, kommentti, pvm);
        //parametreilla
        string sql = string.Format("INSERT INTO comment (name, comment, date) VALUES (@name, @comment, @date);");
        try
        {
            MySqlConnection conn = new MySqlConnection(myComments.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //lisätään parametrit
            cmd.Parameters.AddWithValue("@name", nimi);
            cmd.Parameters.AddWithValue("@comment", kommentti);
            cmd.Parameters.AddWithValue("@date", pvm);
            int lkm = cmd.ExecuteNonQuery();
            lblMessages.Text = string.Format("lisätty {0} kommenttia kantaan", lkm);
            gvComments.DataBind();
        }
        catch (Exception ex)
        {

            lblMessages.Text = ex.Message;
        }
    }
}