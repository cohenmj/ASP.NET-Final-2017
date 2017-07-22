<%@ Page Title="" Language="C#" MasterPageFile="~/Cohen.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Cohen451Final.QuestionA.Products1" %>

<asp:Content ID="BodyContent" 
    ContentPlaceHolderID="MainContent" 
    runat="server">
    <div>
        <asp:GridView ID="Products" 
            runat="server" 
            DataSourceId="FinalExam" 
            AutoGenerateColumns="false">
            <Columns>
                <asp:HyperLinkField HeaderText="Product" 
                    DataTextField="Name" 
                    DataNavigateUrlFields="ProductID" 
                    DataNavigateUrlFormatString="ProductDetails.aspx?product_id={0}" />
                <asp:BoundField DataField="Description" 
                    HeaderText="Description" />
                <asp:BoundField DataField="Price" 
                    HeaderText="Price" 
                    HtmlEncode="false" 
                    DataFormatString="{0:c}" />
                <asp:BoundField DataField="Type" 
                    HeaderText="Type" />
            </Columns>
        </asp:GridView>
        <hr />
        <asp:Label ID="lblProductCount" 
            runat="server" >
        </asp:Label>
        <asp:Label ID="lbl1" 
            runat="server" 
            Text=" Items in Cart">
        </asp:Label>
    </div>

    <asp:SqlDataSource ID="FinalExam" 
        runat="server" 
        SelectCommand="SELECT * FROM Product"
        ConnectionString="<%$ ConnectionStrings:FinalExam %>" >
    </asp:SqlDataSource>
</asp:Content>

