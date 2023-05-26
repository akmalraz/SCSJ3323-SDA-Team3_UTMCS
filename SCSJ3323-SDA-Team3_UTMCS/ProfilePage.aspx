<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Styles/main.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header">
        <h1>User Profile</h1>
    </div>
    <div class="content">
        <label class="form-label">Matrix ID:</label>
        <asp:Label ID="lblMatrixId" runat="server" CssClass="form-field"></asp:Label>
        <br />
        <label class="form-label">Password:</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-field"></asp:TextBox>
        <br />
        <label class="form-label">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-field"></asp:TextBox>
        <br />
        <label class="form-label">Name:</label>
        <asp:TextBox ID="txtName" runat="server" CssClass="form-field"></asp:TextBox>
        <br />
        <label class="form-label">Phone Number:</label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" TextMode="Number" CssClass="form-field"></asp:TextBox>
        <br />
        <label class="form-label">Profile Picture:</label>
        <asp:FileUpload ID="fileProfilePic" runat="server" CssClass="form-field" />
        <br />
        <asp:Image ID="imgProfilePic" runat="server" Width="150px" Height="150px" CssClass="form-field" />
        <br />
        <asp:HiddenField ID="hdnProfilePicPath" runat="server" />
        <br />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn" OnClick="btnEdit_Click" />
        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" Visible="False" OnClick="btnSave_Click" />
    </div>
</asp:Content>

