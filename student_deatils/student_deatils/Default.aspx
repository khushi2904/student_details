<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="student_deatils._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
    <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
    <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
    <br /><br />
    <asp:Label ID="lblname" runat="server" Text="Name : " Visible="false"></asp:Label>
    <asp:TextBox ID="txtname" runat="server" Visible="false"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;
    
    <asp:Label ID="lblmarks" runat="server" Text="Marks : " Visible="false"></asp:Label>
    <asp:TextBox ID="txtmarks" runat="server" Visible="false"></asp:TextBox>

    <br /><br />
    <asp:Label ID="lblerror" runat="server" Text="" Visible="false"></asp:Label>

    <br /><br />
    <asp:Button ID="btnsubmit" runat="server" Text="submit" Visible="false" OnClick="btnsubmit_Click" />

</asp:Content>
