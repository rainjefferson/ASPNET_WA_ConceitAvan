using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_WA_WF_Conceit_Avanc
{
    public partial class LoginCookies : System.Web.UI.Page
    {
        List<String> Usuarios = new List<String>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios.Add("Jefferson");
            Usuarios.Add("Rafaela");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Usuarios)
            {
                if (item == txtLogin.Text)
                {
                    if (txtSenha.Text == "")
                    {
                        Response.Write("<script>alert('Informe a senha!');</script>");
                    } 
                    else if(!(txtSenha.Text == "123"))
                    {
                        Response.Write("<script>alert('Senha diferente de 123!');</script>");
                    } else
                    {
                        // Adicionando cookies
                        HttpCookie cookieNomeUsuario = new HttpCookie("login", txtLogin.Text);
                        cookieNomeUsuario.Secure = true;
                        cookieNomeUsuario.HttpOnly = true;
                        cookieNomeUsuario.Expires = DateTime.Now.AddMinutes(FormsAuthentication.Timeout.TotalMinutes);
                        Response.Cookies.Add(cookieNomeUsuario);

                        //session
                        Session["Login"] = txtLogin.Text;

                        Response.Redirect("~/wfSalarioMinimo.aspx");
                    }
                }
            }
        }
    }
}