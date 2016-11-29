using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GetFeeds();
    }

    protected void GetFeeds()
    {
        xdsTheatres.DataFile = @"http://www.finnkino.fi/xml/TheatreAreas/";
        XmlDocument theatreAreas = new XmlDocument();
        theatreAreas = xdsTheatres.GetXmlDocument();
        XmlNodeList nodes = theatreAreas.SelectNodes("/TheatreAreas/TheatreArea");

        foreach (XmlNode node in nodes)
        {
            lbTheatres.Items.Add(new ListItem(node["Name"].InnerText, node["ID"].InnerText));
        }
    }

    protected void lbTheatres_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbTheatres.SelectedIndex == 0)
            lblMessages.Text = "Aluetta ei valittu.";
        else
            lblMessages.Text = lbTheatres.SelectedItem.ToString() + " valittu.";
        XdsShows.DataFile = @"http://www.finnkino.fi/xml/Schedule/?area=" + lbTheatres.SelectedValue.ToString();
        XmlDocument shows = new XmlDocument();
        shows = XdsShows.GetXmlDocument();

        XmlNodeList nodes = shows.SelectNodes("/Schedule/Shows/Show/Images/EventSmallImagePortrait");
        List<String> images = new List<string>();
        foreach (XmlNode node in nodes)
        {

            if (!images.Contains(node.InnerText))
                images.Add(node.InnerText);
        }
        rptMovies.DataSource = images;
        rptMovies.DataBind();
    }
}