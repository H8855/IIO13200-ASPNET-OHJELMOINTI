﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class RSSFeedit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //asetetaan XmlDataSource pointtaamaan RSS-feediin
        xdsFeedit.DataFile = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        GetFeeds();
    }

    protected void GetFeeds()
    {
        try
        {
            //hakee xml:n XmlDocument-olioon
            XmlDocument doc = new XmlDocument();
            doc = xdsFeedit.GetXmlDocument();
            //rss-feedin title ja julkaisuaika
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string otsikko = node1["title"].InnerText;
            //string jaika = node1["pubDate"].InnerText;
            ltMessages.Text = string.Format("<h1>{0}</h1>", otsikko);
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");
            string rsscategory = "";
            string rsstitle = "";
            string rsslink = "";
            foreach (XmlNode item in nodes)
            {
                //TODO loopitetaan kaikki itemit
                rsscategory = item["category"].InnerText;
                rsstitle = item["title"].InnerText;
                rsslink = item["link"].InnerText;
                ltMessages.Text += string.Format("{2} <a href='{0}'>{1}</a><br>", rsslink, rsstitle, rsscategory);
            }
            //tulos            
        }
        catch (Exception ex)
        {
            ltMessages.Text = ex.Message;
        }
    }

    protected void btnGetFeedsYle_Click(object sender, EventArgs e)
    {
        //asetetaan XmlDataSource pointtaamaan RSS-feediin
        xdsFeedit.DataFile = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
        GetFeeds();
    }
}