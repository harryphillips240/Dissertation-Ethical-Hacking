<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="MAYTEST.Help" %>

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


    <p>
        <br />
    </p>


    <main role="main">

        <br />
      
        <div class="container">
            <div class="row">

                <div class="col-md-4">
                    <h2>Brute force</h2>
                    <p><h3>Easy</h3></p>
                    The easy mode of brute force is common sense to most people. The developer hasnt implemented any protection so you can simply spam requests
                    as often as you want, either by hand or with a third party tool like burp suite until you get a correct combination.
                    <p><h3>Hard</h3></p>
                    When you try and spam requests you will be met with a timeout. This is because the developer has added some protection, you cant type anything into the text boxes
                    for 30 seconds after inputting incorrect details. The workaround is using the burpsuite intruder tool. 
                    <p></p>
                    First intercept the request in burp suite using your proxy, add the textbox params if needed (in the case where they are disabled), then right click and send
                    to the intruder, here we can start an attack. Highlight the inputs of the textboxes and select the clusterbomb attack mode, input your list of chosen usernames and passwords and start the attack.
                    You are looking for a different status code to show the combination worked or you can use the Grep tool to look for certain words like "login" to determine a successful combination.
                    <p><h3>Secure</h3></p>
                    Now the developer has upped their game. The thread the application is running on will be put to sleep for 5 seconds after an incorrect attempt, meaning no code can run,
                    slowing burpsuite to a crawl and drastically increasing the time to brute force the page.
                </div>
                <div class="col-md-4">
                    <h2>SQLi</h2>
                    <p><h3>Easy</h3></p>
                    You can check that the database is vulnerable to SQLi by putting <b>'OR 1=1--</b> This will show the whole table of Pets because its saying WHERE TRUE, from here you can use 
                    <b>' UNION (SELECT NULL,TABLE_NAME, TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES)-- 
                    </b> to see all the tables in the database and then <b> ' UNION SELECT NULL,NULL,column_name FROM information_schema.COLUMNS-- </b> to find the column names, from there you can
                    make your own statement like <b>'UNION SELECT * FROM Users-- </b> which would select and display all the data in the Users table.
                    <p><h3>Hard</h3></p>
                    In this section the developer has implemented some validation on the textbox, so you can't type your statements, you will need to use burp suite to intercept a request and change the values before forwarding it,
                    allowing you to run any statements you want. To do this, turn intercept on in burp suite with your proxy on and send any valid request, when its intercepted click params and change the relevant values.
                    <p><h3>Secure</h3></p>
                    In this secure version the developer has used SQL statements with parameterized queries, meaning the only thing the user affects is specific values of the statement, not the whole thing. This means you are unable to do
                    any statement you like, even while using burp suite.
                </div>
                <div class="col-md-4">
                    <h2>XSS</h2>
                    <p><h3>Easy</h3></p>
                    For the easy level its as simple as typing in some code using script tags, each type of XSS is different but the result is the same, the script will run because the developer has no security implemented whatsoever. 
                    <p><h3>Hard</h3></p>
                    The developer has added validation for this stage, typing <b>script</b> of any case in textboxes or in the URL will result in it being detected and stopped, however this code only checks for the script tag, nothing else,
                    so you can use <b>img src=x onerror=alert("XSS")</b> which searches for an image, and then when the image isn't found, it runs the second bit of code, which bypasses 
                    the validation because there is no script tag. For DOM you can put in a valid URL param and then put the script afterwards, it will accept this as valid and run the code because its check if langauage equals and option,
                    if it equals an option but also contains script then it will pass.
                    <p><h3>Secure</h3></p>
                    In the secure version of these vulnerabilities the developer uses HTML encoding, when you HTML encode the tags it changes them to something else. If you
                    view the source code of the page you will see how they all have been changed due to the endcoding, meaning the code wont run. Persistent XSS is shown as an example but its the same for all 3.
                </div>
            </div>
        </div>

    </main>



    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
