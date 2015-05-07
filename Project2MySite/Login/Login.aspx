<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project2MySite.Login.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/LoginStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {width: 100%;}
        .auto-style2 {width: 188px;}
    </style>
</head>
<body>
    <form id="formLogin" runat="server">
    <div>
        <asp:Label ID="LabelLoginWelcome" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Welcome"></asp:Label>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>
        <asp:Label ID="LabelLoginUsername" runat="server" Text="Username: " Font-Size="Medium"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TextBoxLoginUsername" runat="server" TabIndex="1"></asp:TextBox>
                </td>
                <td class="auto-style2">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="TextBoxLoginUsername" ErrorMessage="* Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="LabelLoginPassword" runat="server" Text="Password: " Font-Size="Medium"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TextBoxLoginPassword" runat="server" TabIndex="2" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="TextBoxLoginPassword" ErrorMessage="* Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" TabIndex="3" Width="62px" />
    
                </td>
            </tr>
        </table>
        <asp:Label ID="LabelLoginInfo" runat="server" Text="Please log on to proceed"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
