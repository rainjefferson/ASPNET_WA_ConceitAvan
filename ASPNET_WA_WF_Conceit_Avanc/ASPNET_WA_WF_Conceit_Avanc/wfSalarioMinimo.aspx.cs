using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_WA_WF_Conceit_Avanc
{
    public partial class wfSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginCookie.Text = "";
            if (Request.Cookies["login"] != null)
            {
                lblLoginCookie.Text = "Login recuperado do cookie: " + Request.Cookies["login"].Value;
            }

            if (Session["login"] == null)
            {
                Response.Redirect("~/LoginCookies.aspx");
            }

            lblSessionID.Text = Session.SessionID.ToString();
        }

        protected void RadioButtonOutro_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbOutro = (RadioButton)sender;
            TextBox1.Visible = rbOutro.Checked; 
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
        }

        protected void btnRemoveCookie_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                //Apaga todos os cookies
                //Response.Cookies.Clear();

                // remove cookie especifico
                // Response.Cookies.Remove("login");
                // Apaga os cookies que estão na variavel, mas não os cookies do computador/browser
                Request.Cookies.Remove("login");
                lblLoginCookie.Text = "";
            }
        }

        protected void btnListarCookies_Click(object sender, EventArgs e)
        {
            var keys = Request.Cookies.AllKeys;
            String texto = "<p>";
            for (int c = 0; c < Request.Cookies.Count; c++)
            {
                texto += "Pos: " + keys[c] + Request.Cookies[keys[c]].Value + " ";
            }
            texto += "</p>";
            Response.Write("<h3>Lista de cookies:</h3>");
            Response.Write(texto);
        }
    }
}