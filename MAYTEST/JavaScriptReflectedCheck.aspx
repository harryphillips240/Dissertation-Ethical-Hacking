<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavaScriptReflectedCheck.aspx.cs" Inherits="MAYTEST.JavaScriptRelectedCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style type='text/css'>
        .CustomButton {
            background: #6cb200;
            color: #fff;
            border: 0;
            padding: 10px 15px;
            font-size: 14px;
            display: inline-block;
            text-transform: uppercase;
            margin-bottom: 18px;
        }

            .CustomButton:hover {
                background: #89c33f;
            }
    </style>
</head>
<body>
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            Type English, German, or French<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass ="CustomButton" Text="Set language" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:Image ID="Flag" runat="server" Height="40px" ImageUrl="C:\Users\harry\source\repos\MAYTEST\MAYTEST\Content\Images\englishflag.jpg" Width="60px" />
        </div>
        <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
            <a class="navbar-brand">954519</a>
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

        <div>
        </div>
    </form>
</body>
</html>
