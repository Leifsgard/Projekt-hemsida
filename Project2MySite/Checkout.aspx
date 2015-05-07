<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Project2MySite.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="WebShopData.ProjectWebStoreDataSetTableAdapters.OrderHeadTableAdapter" UpdateMethod="Update">
        <InsertParameters>
            <asp:Parameter Name="UserID" Type="Int32" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Zip" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Processed" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UserID" Type="Int32" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Zip" Type="String" />
            <asp:Parameter Name="City" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <table style="width: 113%">
        <tr>
            <td style="width: 78px">
                <asp:Label ID="LabelName" runat="server" Text="Name: " ForeColor="Black"></asp:Label>
            </td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBoxName" runat="server" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" ControlToValidate="TextBoxName" ErrorMessage="* What name is on your Driver license?" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 78px; height: 29px;">
                <asp:Label ID="LabelAdress" runat="server" Text="Adress: " ForeColor="Black"></asp:Label>
            </td>
            <td style="width: 410px; height: 29px;">
                <asp:TextBox ID="TextBoxAdress" runat="server" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAdress" runat="server" ControlToValidate="TextBoxAdress" ErrorMessage="* So, where do we send the papers?" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 78px">
                <asp:Label ID="LabelZip" runat="server" Text="ZipCode: " ForeColor="Black"></asp:Label>
            </td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBoxZip" runat="server" ForeColor="Black" Width="150px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorZip" runat="server" ControlToValidate="TextBoxZip" Display="Dynamic" ErrorMessage="* Do not forget the ZipCode: 123 45" Font-Bold="False" Font-Underline="False" ForeColor="Red" ValidationExpression="\d{3}[ ]?\d{2}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 78px">
                <asp:Label ID="LabelCity" runat="server" Text="City: " ForeColor="Black"></asp:Label>
            </td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBoxCity" runat="server" ForeColor="Black" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" ControlToValidate="TextBoxCity" Display="Dynamic" ErrorMessage="* Can we get a city?" Font-Italic="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 78px">
                <asp:Label ID="LabelEmail" runat="server" Text="Email: " ForeColor="Black"></asp:Label>
            </td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBoxEmail" runat="server" Width="150px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="* We want to spam you, enter your email!" Font-Bold="False" Font-Underline="False" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
<br />
    <asp:Button ID="ButtonClear" runat="server" CausesValidation="False" OnClick="ButtonClear_Click" style="margin-bottom: 0px" Text="Clear Order" />
<asp:Button ID="ButtonCashier" runat="server" OnClick="ButtonCashier_Click" Text="Send Order" Visible="False" />
            <br />
            <br />
 <table id="confirmation" style="width: 70%">
        <tr >
            <td style="background-color: #FF0000">
                <asp:Label ID="Label1" runat="server" Font-Underline="True" BackColor="Red" ForeColor="White">APARTMENT</asp:Label>
            </td>
            <td style="background-color: #FF0000">
               <asp:Label ID="Label2" runat="server" Font-Underline="True" BackColor="Red" ForeColor="White">PRICE</asp:Label> 
            </td>
            <td style="background-color: #FF0000">
               <asp:Label ID="Label3" runat="server" Font-Underline="True" BackColor="Red" ForeColor="White">QUANTITY</asp:Label> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelProduct" runat="server" BackColor="White" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelPrice" runat="server" BackColor="White" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelQuantity" runat="server" BackColor="White" ForeColor="Black"></asp:Label>
            </td>
        </tr>

        <tr>
            <td><asp:Label ID="LabelTotalSum" runat="server" BackColor="White" Font-Bold="True" ForeColor="Black"></asp:Label></td>

        </tr>
    </table>
    
</asp:Content>
