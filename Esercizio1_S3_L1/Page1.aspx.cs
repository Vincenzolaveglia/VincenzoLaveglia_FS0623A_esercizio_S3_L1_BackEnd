using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio1_S3_L1
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write($"Nome: {ConfigurationManager.AppSettings["nome"]}, " +
                           $"Cognome: {ConfigurationManager.AppSettings["cognome"]}");
        }
    }
}