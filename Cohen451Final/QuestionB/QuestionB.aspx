<%@ Page Title="" Language="C#" MasterPageFile="~/Cohen.Master" AutoEventWireup="true" CodeBehind="QuestionB.aspx.cs" Inherits="Cohen451Final.QuestionB.QuestionB" %>

<asp:Content ID="BodyContent" 
    ContentPlaceHolderID="MainContent" 
    runat="server">
        <div>
            <asp:Label ID="lblProdID" 
                runat="server" 
                Text="Please enter product ID">
            </asp:Label>
            <br />
            <input id="txtProdID" 
                type="text" 
                runat="server" />
            <asp:Button ID="btnSubmit" 
                runat="server" 
                Text="Submit" 
                OnClick="btnSubmit_Click" />
            <br />
            <asp:GridView ID="gvProduct" 
                runat="server">
            </asp:GridView>
        </div>
    </asp:Content>
