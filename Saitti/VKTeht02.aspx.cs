using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.ICT;

public partial class VKTeht02 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ddlRows.Items.Count == 0)
        {
            for(int i = 0; i<=10; i++)
            {
                ddlRows.Items.Add(new ListItem(Convert.ToString(i)));
            }
        }
    }

    protected void btnDraw_Click(object sender, EventArgs e)
    {
        divRows.InnerHtml = "Arvotut rivit: <br>";
        Lotto lotto = new Lotto();
        lotto.Tyyppi = ddlType.SelectedValue;
        for (int i = 0; i < Convert.ToInt32(ddlRows.SelectedValue); i++)
        {
            ArrayList drawnRows = lotto.Draw();
            foreach (var number in drawnRows)
            {
                divRows.InnerHtml += number + "   ";
            }
            divRows.InnerHtml += "<br>";
        }

        
    }
}