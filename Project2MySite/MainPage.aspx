<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Project2MySite.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
   
    
     <asp:GridView ID="GridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSourceProducts" DataKeyNames="ArticleID" Width="90%" OnRowCommand="GridView_RowCommand" HorizontalAlign="Center" OnSelectedIndexChanged="GridView_SelectedIndexChanged" CssClass="GridViewCss">
       
          <Columns>
            <asp:BoundField DataField="ArticleID" HeaderText="Product" ItemStyle-CssClass="hiddencol" SortExpression="ArticleID"  >
              <ItemStyle HorizontalAlign="Right" Width="100px" />
              </asp:BoundField>
            <asp:BoundField DataField="Text" HeaderText="Price" SortExpression="Text" >
              <ControlStyle Width="300px" />
              <ItemStyle Width="70%" />
              </asp:BoundField>
              <asp:BoundField DataField="UnitPrice" HeaderText="Buy" SortExpression="UnitPrice" >
              <ControlStyle Width="100px" />
              <ItemStyle Width="100px" />
              </asp:BoundField>
              <asp:ButtonField ButtonType="Button" CommandName="AddToCart" Text="Add" >
              <ItemStyle HorizontalAlign="Center" Width="100px" />
              </asp:ButtonField>
        </Columns>

    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:ShopDB %>" SelectCommand="SELECT * FROM [Articles]"></asp:SqlDataSource>
&nbsp;
</asp:Content>