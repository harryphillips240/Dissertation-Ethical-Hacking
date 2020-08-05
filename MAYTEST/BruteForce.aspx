<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BruteForce.aspx.cs" Inherits="MAYTEST.BruteForce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <style type='text/css'>

        
    .CustomButton
    {
        background: #6cb200;
        color: #fff;
        border: 0;
        padding: 10px 15px;
        font-size: 14px;
        display: inline-block;
        text-transform: uppercase;
        margin-bottom: 18px;
    }
    .CustomButton:hover
    {
        background: #89c33f;
    }

    </style>
</head>
<body>
    <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
      <a class="navbar-brand" >954519</a>

      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <a class="nav-link" href="Home.aspx">Home <span class="sr-only">(current)</span></a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="Reset.aspx">Reset</a>
          </li>
      </div>
    </nav>

    <br />
    <br />
    <br />
    
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
        <div style="margin-left: 40px">
            &nbsp;Username:&nbsp;&nbsp;
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div style="margin-left: 40px">
            &nbsp;Password: &nbsp;&nbsp;&nbsp;<asp:TextBox ID="Password" runat="server"></asp:TextBox>
        </div>
        <br />
        <div style="margin-left: 160px">
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="CustomButton" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
