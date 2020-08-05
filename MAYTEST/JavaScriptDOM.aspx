<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavaScriptDOM.aspx.cs" Inherits="MAYTEST.JavaScriptDOM" %>

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
        </div>
    </form>
    <br />
</body>
<!-- This is the code for DOM -->
<p>Select language:</p>
<form name="DOM" method="GET">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <select name="language">
                <script>
                    var pos = document.URL.indexOf("language=") + 9;
                    //gets position of params in the url 
                    
                    //if there is a param in url
                    if (document.URL.length != 42) {
                        //get param
                        var lang = document.URL.substring(pos);
                        //write it 
                        document.write("<option>" + "Current language: " + decodeURI(lang) + "</option>");
                    } else {
                        //if no params, tell them to pick
                        document.write("<option>" + "Select a language " + "</option>");
                        
                    }
                    
                    document.write("<option>English</option>");
                    document.write("<option>German</option>");
                    document.write("<option>French</option>");     
                </script>
            </select>
    <input type="submit" value="SELECT LANGUAGE" class="CustomButton" />
    <p class="tab">
        <script>document.write("Selected language: ");</script>

        <img src="" width="60" height="40" id="flag">
        <script>
                            var lang = document.URL.substring(document.URL.indexOf("language=") + 9);
       lang = lang.toLowerCase();
       document.getElementById('flag').src = "Content/Images/" + lang + "flag.jpg";
        </script >
    </p>

</form>

</html>
