<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="boot.aspx.cs" Inherits="MAYTEST.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="/docs/4.0/assets/img/favicons/favicon.ico">

    <title>954519</title>
</head>

<body data-gr-c-s-loaded="true">


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

    <main role="main">


        <div class="jumbotron">
            <div class="container">
                <h1 class="display-4">Welcome to my vulnerable web application!</h1>
                <p>Choose a vulnerability to start from the list below, get stuck in or click the links below to find more general information as well as guides and explanations I have written: </p>
                <p><a href="https://portswigger.net/burp/documentation/desktop/getting-started">Getting started with Burp Suite</a> by PortSwigger</p>
                <p><a href="https://owasp.org/www-community/attacks/Brute_force_attack">Brute Force</a> by OWASP</p>
                <p><a href="https://owasp.org/www-project-top-ten/OWASP_Top_Ten_2017/Top_10-2017_A1-Injection">Injection</a> by OWASP</p>
                <p><a href="https://owasp.org/www-project-top-ten/OWASP_Top_Ten_2017/Top_10-2017_A7-Cross-Site_Scripting_(XSS)">Cross-Site Scripting</a> by OWASP</p>
                <p><a class="btn btn-primary btn-lg" href="Help.aspx" role="button">Guide (Spoilers) »</a>   <a class="btn btn-primary btn-lg" href="InDepthBruteForce.html" role="button">Brute force in-depth »</a> 
                <a class="btn btn-primary btn-lg" href="InDepthSQL.html" role="button">SQLi in-depth »</a>
                <a class="btn btn-primary btn-lg" href="InDepthXSS.html" role="button">XSS in-depth »</a></p>


            </div>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <h2>Brute force</h2>
                    <p><h3>Easy</h3></p>
                    <a class="btn btn-secondary" href="BruteForce.aspx" role="button">Brute Force »</a>
                    <p><h3>Hard</h3></p>
                    <a class="btn btn-secondary" href="BruteForceLock.aspx" role="button">Brute Force Lockout »</a>
                    <p><h3>Secure</h3></p>
                    <a class="btn btn-secondary" href="BruteForceSleep.aspx" role="button">Brute Force Sleep »</a>
                </div>
                <div class="col-md-4">
                    <h2>SQL injection</h2>
                    <p><h3>Easy</h3></p>
                    <a class="btn btn-secondary" href="LoginPage.aspx" role="button">Search »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="RegistrationPage.aspx" role="button">Registration Page »</a>
                    <p><h3>Hard</h3></p>
                    <a class="btn btn-secondary" href="ValidationSQL.aspx" role="button">Validation client-side »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="DropDownSQL.aspx" role="button">Drop Down List»</a>
                    <p><h3>Secure</h3></p>
                    <a class="btn btn-secondary" href="SecureSQL.aspx" role="button">Secure example »</a>
                </div>
                <div class="col-md-4">
                    <h2>Cross site scripting</h2>
                    <p><h3>Easy</h3></p>
                    <a class="btn btn-secondary" href="JavaScriptPersistent.aspx" role="button">JavaScript Persistent »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="JavaScriptReflected.aspx?language=English" role="button">JavaScript Reflected »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="JavaScriptDOM.aspx?language=English" role="button">JavaScript DOM »</a>
                    <p><h3>Hard</h3></p>
                    <a class="btn btn-secondary" href="JavaScriptPersistentCheck.aspx" role="button">JavaScript Persistent Validation »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="JavaScriptReflectedCheck.aspx?language=English" role="button">JavaScript Reflected Validation »</a>
                    <p></p>
                    <a class="btn btn-secondary" href="JavaScriptDOMCheck.aspx?language=English" role="button">JavaScript DOM Validation »</a>
                    <p><h3>Secure</h3></p>
                    <a class="btn btn-secondary" href="JavaScriptPersistentSecure.aspx" role="button">JavaScript Persistent Secure »</a>
                    <p></p>
                </div>
            </div>

            
        </div>

    </main>

</body>

</html>
