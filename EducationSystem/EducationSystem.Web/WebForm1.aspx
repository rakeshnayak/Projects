<%@ Page Title="" Language="C#" MasterPageFile="~/EducationSystem.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EducationSystem.Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>
    Using Forms Authentication</h3>
  <asp:Label ID="Welcome" runat="server" />
    <asp:Button ID="Submit1" OnClick="Signout_Click" Text="Sign Out" runat="server" />
</asp:Content>
