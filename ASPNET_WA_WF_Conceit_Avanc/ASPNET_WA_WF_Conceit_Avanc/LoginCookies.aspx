<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCookies.aspx.cs" Inherits="ASPNET_WA_WF_Conceit_Avanc.LoginCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="209px">
                Login:
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <br />
                <br />
                Senha:<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entrar" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
