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
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/wfRespostaSalarioMinimo.aspx?Nome=JeffersonRain">Metodo GET</asp:HyperLink>
        </div>
    </form>
</body>
</html>
