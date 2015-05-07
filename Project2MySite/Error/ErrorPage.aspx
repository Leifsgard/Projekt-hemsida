<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Project2MySite.Error.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/ErrorStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="topMessage">
            <asp:Label ID="LabelError" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Opps...."></asp:Label>
            <p>Seems like someone forgot to read the manual. We are deeply sorry for the inconvenience.</p>
        </div>
        
    <div>
        <img src="../Images/error.jpg" />
    </div>
    </form>
</body>
</html>
