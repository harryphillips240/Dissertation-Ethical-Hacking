<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BruteForceLock.aspx.cs" Inherits="MAYTEST.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
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

    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            Username:<asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            Password:
        <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
        </p>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div style="margin-left: 200px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="CustomButton" Text="Login" />
        </div>
        <asp:Timer ID="Timer1" runat="server" Interval="30000" OnTick="Timer1_Tick">
        </asp:Timer>
    </form>
</body>
</html>
