<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Cohen451Final.QuestionA.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvProductDetails" 
            runat="server">
        </asp:GridView>
        
        <asp:Button ID="btnAddItem" 
            runat="server" 
            Text="Add Item" 
            OnClick="btnAddItem_Click" />
        
        <asp:HyperLink ID="hlProducts" 
            runat="server" 
            NavigateUrl="~/QuestionA/Products.aspx">
            Back to Products
        </asp:HyperLink>
    </div>
    </form>
</body>
</html>
