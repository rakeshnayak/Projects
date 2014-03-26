<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="EducationSystem.Web.adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="Styles/Custom/EducationSystem.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #divMenu
        {
            height: 50px;
            border: 0;
            background-color: #2c3e50;
            background-repeat: repeat-x; /* Safari 4-5, Chrome 1-9 */
            background: -webkit-gradient(linear, 0% 0%, 0% 100%, from(#2c3e50), to(#ffffff)); /* Safari 5.1, Chrome 10+ */
            background: -webkit-linear-gradient(top, #ffffff, #2c3e50); /* Firefox 3.6+ */
            background: -moz-linear-gradient(top, #ffffff, #2c3e50); /* IE 10 */
            background: -ms-linear-gradient(top, #ffffff, #2c3e50); /* Opera 11.10+ */
            background: -o-linear-gradient(top, #ffffff, #2c3e50);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divHeader">
    </div>
    <div id="divMenu">
    </div>
    <div id="divBody" align="center">
    <div style="height:100px;">
    </div>
        <div class="panel panel-primary" style="width: 400px;">
            <div class="panel-heading">
                <h3 class="panel-title">
                    Admin Login
                </h3>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label for="txtUserName" class="col-sm-4 control-label">
                        User Name:
                    </label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" id="txtUserName" placeholder="User Name">
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtPassword" class="col-sm-4 control-label">
                        Password:
                    </label>
                    <div class="col-sm-8">
                        <input type="password" class="form-control" id="txtPassword" placeholder="Password">
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-4 col-sm-8">
                        <div class="checkbox">
                            <label>
                                <input type="checkbox" />
                                Remember me
                            </label>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-4 col-sm-8">
                        <button type="submit" class="btn btn-default">
                            Sign in
                        </button>
                    </div>
                </div>
            </div>
            <div class="panel-footer">
                <div class="form-group">
                    <div class="col-sm-6">
                        <a href="#">Forgot Password?</a>
                    </div>
                    <div class="col-sm-6">
                        <a href="login.aspx">User Login</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="divFooter">
    </div>
    </form>
</body>
</html>
