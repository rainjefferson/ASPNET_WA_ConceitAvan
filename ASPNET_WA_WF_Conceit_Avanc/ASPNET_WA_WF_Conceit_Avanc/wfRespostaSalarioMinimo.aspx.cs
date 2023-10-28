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
            //Response.Write("<h1>Objetos response:</h1>");
            // Recursos Request são pegos de envio GET ou POST, tanto faz.
            //Response.Write("<h3>txtSalB: " + Request["txtSalB"] + "</h3>");
            //Response.Write("<h3>txtPercent: " + Request["txtPercent"] + "</h3>");

            // Recursos Request são pegos de envio por metodo FORM - POST.
            //Response.Write("<h3>txtSalB (Form): " + Request.Form["txtSalB"] + "</h3>");

            // Recursos Request são pegos de envio por metodo GET.
            //Response.Write("<h3>Nome (GET): " + Request.QueryString["Nome"] + "</h3>");

            // Se não tiver valor de salário, redireciona para a pagina principal
            if (Request["txtSalB"] == null)
            {
                Response.Redirect("~/wfSalarioMinimo.aspx");
            } 

            // Calcular o desconto do salarioa aqui
            Double valorSalLiq = ((100-Convert.ToDouble(Request["txtPercent"])) / 100 *
                                  Convert.ToDouble(Request["txtSalB"]));
            Response.Write("<h1>Valor do Salário liquido:</h1>");
            Response.Write("<h3>R$ " + valorSalLiq + "</h3>");

            RadioButton r1 = (RadioButton)Page.PreviousPage.FindControl("RadioButton1");
            RadioButton r2 = (RadioButton)Page.PreviousPage.FindControl("RadioButton2");
            RadioButton r3 = (RadioButton)Page.PreviousPage.FindControl("RadioButton3");
            RadioButton rO = (RadioButton)Page.PreviousPage.FindControl("RadioButton4");

            Double Percentual = 0;

            if (r1.Checked)
            {
                Percentual = 10;
            }
            else if (r2.Checked)
            {
                Percentual = 20;
            }
            else if (r3.Checked)
            {
                Percentual = 30;
            }
            else if (rO.Checked)
            {
                TextBox txPO = (TextBox)Page.PreviousPage.FindControl("TextBox1");
                Percentual = Convert.ToDouble(txPO.Text);
            }
            
            valorSalLiq = (((100 - Percentual)) / 100 * Convert.ToDouble(Request["txtSalB"]));
            Response.Write("<h3>Calculado por radiobuton de percentuais:</h3>");
            Response.Write("<h3>R$ " + valorSalLiq + "</h3>");
        }
    }
}