﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookShop : System.Web.UI.Page
{
    protected static BookShopEntities ctx;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //luodaan konteksti
            ctx = new BookShopEntities();
            FillControls();
        }
    }
    #region METHODS
    protected void GetBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
    }
    protected void GetCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
    }
    protected void FillControls()
    {
        //UI-kontrollien alustaminen
        var result = from c in ctx.Customers
                     orderby c.lastname
                     select new { c.id, c.lastname };
        //määritellään dropdownlistille mitä se esittää
        ddlCustomers.DataSource = result.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";        
        ddlCustomers.DataBind();
        ddlCustomers.Items.Insert(0, string.Empty);
    }
    #endregion
    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        GetBooks();
    }


    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        GetCustomers();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCustomers.SelectedIndex > 0)
        {
            int cid = -1;
            cid = Int32.Parse(ddlCustomers.SelectedValue);
            //haetaan valittu asiakas
            var ret = from c in ctx.Customers
                      where c.id == cid
                      select c;
            var asiakas = ret.FirstOrDefault();
            if(asiakas != null)
            {
                lblMessages.Text = string.Format("Valitsit asiakkaan {0}", asiakas.lastname);
                //tutkitaan onko asiakkaalla tilauksia ja jos on, näytetään ne
                if (asiakas.Orders.Count > 0)
                {
                    lblMessages.Text += string.Format(", tilauksia {0}.", asiakas.Orders.Count);
                    //täytetään ddl tilauksilla
                    var ret2 = (from o in asiakas.Orders
                               select new { o.odate }).ToList();
                    ddlOrders.DataSource = ret2;
                    ddlOrders.DataTextField = "odate";
                    ddlOrders.DataBind();
                    //haetaan tilausten tilausrivit
                    foreach (var item in asiakas.Orders)
                    {
                        lblMessages.Text += string.Format("<br> tilaus: {0}", item.odate.ToShortDateString());
                        //loopitetaan tilauksen tilausrivit
                        foreach (var or in item.Orderitems)
                        {
                            lblMessages.Text += string.Format("<br> tilattu kirja {0}", or.Book.name);
                        }
                    }
                    

                }
                else
                {
                    lblMessages.Text += ", ei ole tilauksia.";
                    ddlOrders.Items.Clear();
                }
            }
            
        }
    }
}