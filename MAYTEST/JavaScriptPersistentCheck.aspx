<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavaScriptPersistentCheck.aspx.cs" Inherits="MAYTEST.JavaScriptPersistentCheck1" %>

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
    <p>
        <br />
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <b>Welcome to the forum!</b>
    </p>
    <p>
        <b>Post a comment:</b>
    </p>

    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="Comment" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="username" DataValueField="username">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [username] FROM [Users]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="CustomButton" Text="Submit" />
        </p>
        <p>
            <b>Most recent comment:</b>
        </p>
        <p>
            <asp:Label ID="Body" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <b>Posted by:</b>
        </p>
        <p>
            <asp:Label ID="Author" runat="server" Text="Label"></asp:Label>
        </p>
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
