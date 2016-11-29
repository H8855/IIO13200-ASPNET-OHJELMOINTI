using System;
using System.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VKTeht01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        //lasketaan ikkunan tarjoushinta 
        try
        {
            //käyttäjän syötteet on aina syytä tarkistaa
            if (txtKorkeus.Text.Length * txtLeveys.Text.Length * txtKarminLeveys.Text.Length > 0)
            {
                double leveys = Convert.ToDouble(txtLeveys.Text);
                double korkeus = Convert.ToDouble(txtKorkeus.Text);
                double karmi = Convert.ToDouble(txtKarminLeveys.Text);
                double pintaala = (korkeus / 1000) * (leveys / 1000); //m2
                double piiri = 2 * ((leveys / 1000) + (korkeus / 1000)); //jm
                double aluhinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiininhinta"]); // €/m2
                double lasihinta = Convert.ToDouble(ConfigurationManager.AppSettings["lasinhinta"]); // €/jm
                double tyomenekki = Convert.ToDouble(ConfigurationManager.AppSettings["tyomenekki"]); // €/ikkuna
                double kate = 0.3; // kate 30%
                //hinnan laskenta
                double hinta = (1 + kate) * ((pintaala * lasihinta) + (piiri * aluhinta) + tyomenekki);
                //tulos UI:in
                lblHinta.Text = hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-FI"));
                lblKarminPiiri.Text = piiri.ToString();
                lblPintaAla.Text = pintaala.ToString();

            }
            else
            {
                lblMessages.Text = "Tarkista syötteet";
            }
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}