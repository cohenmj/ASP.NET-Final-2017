<%@ Page Title="" Language="C#" MasterPageFile="~/Cohen.Master" AutoEventWireup="true" CodeBehind="QuestionD.aspx.cs" Inherits="Cohen451Final.QuestionD.QuestionD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Question D:</p>
<p>
    1)</p>
<p class="MsoNormal">
    When using session state in the e-commerce environment, the first advantage would be no size limitations. Session states have the potential to store large data files, while cookies are limited. The second advantage is that session states can represent more complex objects when scoped to a specific user, unlike cookies where they are limited to simple strings of text. This gives session states the capability to store data in a shopping cart effectively.<a name="OLE_LINK1"> </a>
</p>
<p class="MsoNormal">
    <a name="OLE_LINK1">Throughout the semester, our group used a session to maintain a shopping cart for the “visiting” user. We defined the shopping as a new data table to access an SQL table ‘Products’ that takes in the ‘product_id’ to place the relevant data fields in a grid view. Using the session allowed us to place several products into the grid view, where we then totaled the price and displayed a grand total relating to each item.<o:p></o:p></a></p>
<p>
    2)</p>
<p class="MsoNormal">
    <a name="OLE_LINK2">A User Control is a reusable control using similar techniques that are employed by ASP.NET web pages. These controls act as a unit when they are formed using existing web server controls, but are not used for HTML or XML pages. These are best used for single-application scenarios. An example of creating a user control would be during our assignment #4 where we defined the controls for a phone number. We added a tag prefix, a tag name, and a source name (.ascx). Another example would be creating a footer control to display for each desired web page.<o:p></o:p></a></p>
<p class="MsoNormal">
    <span style="mso-bookmark:OLE_LINK2">A Custom Control is like a user control, but allows use on more than one XML or HTML applications when derived from a Control class or WebControl class. A custom control gives the capability to change the default behavior for an existing class into a new class. Since you are essentially creating an entirely new control, there is a lot of code to incorporate because of no designer support. A WebControl class is used for displaying visual content by adding functionality to the base Control class. An example that was found online created a custom control to check for palindroms, words that are spelled the same when reversed. The custom control class that is created defines the methods in full detail, including font, spacing, and content.<o:p></o:p></span></p>
<p>
    <br />
</p>
</asp:Content>
