using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VKTeht06Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Request.QueryString["record"];
        srcRecords.XPath = string.Format("//record[@ISBN='{0}']", s);
        srcSongs.XPath = string.Format("//record[@ISBN='{0}']/song", s);
    }
}