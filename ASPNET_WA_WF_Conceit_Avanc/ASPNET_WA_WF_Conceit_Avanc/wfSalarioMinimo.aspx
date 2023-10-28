<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfSalarioMinimo.aspx.cs" Inherits="ASPNET_WA_WF_Conceit_Avanc.wfSalarioMinimo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Informe o salário bruto:"></asp:Label>
            <br />
            <asp:TextBox ID="txtSalB" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Percentual de desconto:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPercent" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/wfRespostaSalarioMinimo.aspx" Text="Enviar dados" />
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" GroupName="perc" OnCheckedChanged="RadioButton1_CheckedChanged" Text="10%" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="perc" OnCheckedChanged="RadioButton1_CheckedChanged" Text="20%" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" GroupName="perc" OnCheckedChanged="RadioButton1_CheckedChanged" Text="30%" />
            <br />
            <asp:RadioButton ID="RadioButtonOutro" runat="server" AutoPostBack="True" GroupName="perc" OnCheckedChanged="RadioButtonOutro_CheckedChanged" Text="Outro" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/wfRespostaSalarioMinimo.aspx?Nome=JeffersonRain">Metodo GET</asp:HyperLink>
            <br />
            <br />
            <br />
            Carregamento de Cookies armazenados na pagina LoginCookies.aspx<br />
            <br />
            <asp:Label ID="lblLoginCookie" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblSessionID" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnRemoveCookie" runat="server" OnClick="btnRemoveCookie_Click" Text="Remover Cookie" />
&nbsp;
            <asp:Button ID="btnListarCookies" runat="server" OnClick="btnListarCookies_Click" style="margin-bottom: 0px" Text="Listar Cookies" />
        </div>
    </form>
</body>
</html>
