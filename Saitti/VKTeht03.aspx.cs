using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VKTeht03 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblDateToday.Text = "Tänään on: " + DateTime.Today.ToShortDateString();
            cldrDateChoose.VisibleDate = DateTime.Today;
            lblDateChosen.Text = "Valitsemasi päivä: ";
            lblDateDifference.Text = "";
        }
        
    }

    protected void cldrDateChoose_SelectionChanged(object sender, EventArgs e)
    {
        //dateChosen = cldrDateChoose.SelectedDate;
        lblDateChosen.Text = "Valitsemasi päivä: " + cldrDateChoose.SelectedDate.ToShortDateString();
        DateDiff difference = new DateDiff(DateTime.Today, cldrDateChoose.SelectedDate);
        lblDateDifference.Text = string.Format("Päivät: {0}, Kuukaudet: {1}, Vuodet: {2}", difference.ElapsedDays, difference.ElapsedMonths, difference.ElapsedYears);
    }

    protected void btnYearDeductOne_Click(object sender, EventArgs e)
    {
        cldrDateChoose.VisibleDate = cldrDateChoose.VisibleDate.AddYears(-1);
    }

    protected void btnYearAddOne_Click(object sender, EventArgs e)
    {
        cldrDateChoose.VisibleDate = cldrDateChoose.VisibleDate.AddYears(1);
    }
}