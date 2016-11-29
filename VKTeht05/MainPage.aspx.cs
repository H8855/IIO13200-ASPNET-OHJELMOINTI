using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    protected static DemoxOyAsiakkaat ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ctx = new DemoxOyAsiakkaat();

            var maat = (from a in ctx.asiakas orderby a.maa select a.maa).Distinct().ToList();
            ddlMaat.DataSource = maat;
            ddlMaat.DataBind();
        }
    }

    protected void btnKaikkiAsiakkaat_Click(object sender, EventArgs e)
    {
        gvAsiakkaat.DataSource = ctx.asiakas.ToList();
        gvAsiakkaat.DataBind();
    }
        

    protected void ddlMaat_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnMaasta_Click(object sender, EventArgs e)
    {        
        var valittuMaa = (from a in ctx.asiakas where a.maa == "FIN" select a).ToList();

        gvAsiakkaat.DataSource = valittuMaa;
        gvAsiakkaat.DataBind();
    }
}