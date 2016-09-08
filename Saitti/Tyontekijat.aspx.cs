using System;
using System.Configuration; //Web.configin lukua varten
using System.Data; // Dataa ja yleisiä ADO.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tyontekijat : System.Web.UI.Page
{
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        // haetaan Web.config:sta
        xmlfilu = ConfigurationManager.AppSettings["xmlfilu"];
        lblMessages.Text = xmlfilu; 
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //haetaan XML-data DataView-olioon, joka kytketään GridView:iin
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu)); // huom: MapPath muuttaa viittauksen web-sivulle
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();
    }
}