using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_WA_WF_Conceit_Avanc
{
    public partial class wfRespostaSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>Objetos response:</h1>");
            // Recursos Request são pegos de envio GET ou POST, tanto faz.
            Response.Write("<h3>txtSalB: " + Request["txtSalB"] + "</h3>");
            Response.Write("<h3>txtPercent: " + Request["txtPercent"] + "</h3>");

            // Recursos Request são pegos de envio por metodo FORM - POST.
            Response.Write("<h3>txtSalB (Form): " + Request.Form["txtSalB"] + "</h3>");

            // Recursos Request são pegos de envio por metodo GET.
            Response.Write("<h3>Nome (GET): " + Request.QueryString["Nome"] + "</h3>");
        }
    }
}