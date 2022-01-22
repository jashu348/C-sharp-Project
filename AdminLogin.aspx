<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    
</head>
   
<body class="alert-success" >
 
        <form id="form1" runat="server">
        <div>
         <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">Banking System</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="#">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#contact">Contact</a></li>
              
               
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
   </div>
    <div class="container" style="background-color:!important">
        <div class="alert-success" style="margin-top:100px;"></div>

        <div class="row">
  <div class="col-md-8">
       <img src="photo/unnamed%20(3).jpg" /></div>
  <div class="col-md-4">


      <div class="form-horizontal" >
  <div class="form-group">
    <label for="inputEmail3" class="col-sm-4 control-label">Admin ID</label>
    <div class="col-sm-8">
   <div class="input-group">
  <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
  <asp:TextBox ID="TextBox1" placeholder="Enter User Id" CssClass="form-control" runat="server"></asp:TextBox>
               
       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Id Should Be Numer" ValidationExpression="[0-9]+"></asp:RegularExpressionValidator>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Id Should Not Be Empty"></asp:RequiredFieldValidator>
               
</div>   </div>
  </div>
  <div class="form-group">
    <label for="inputPassword3" class="col-sm-4 control-label">Password</label>
    <div class="col-sm-8">
     <div class="input-group">
  <span class="input-group-addon"><i class="glyphicon glyphicon-eye-close"></i></span>

                    <asp:TextBox ID="TextBox2" placeholder="Enter Password" runat="server" CssClass="form-control" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Should Not Be Empty"></asp:RequiredFieldValidator>
                </div></div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
      <div class="checkbox">
        <label>
          <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
                
        </label>
      </div>
    </div>
  </div>
  <div class="form-group">
    <div class="col-sm-offset-2 col-sm-10">
         <asp:Button ID="Button1" CssClass="btn btn-success pull-right"  runat="server" OnClick="Button1_Click" Text="Login" />
              </div>
  </div>
</div>


      </div>
</div>


            </div>
             
    
   
    </form>
</body>
</html>
         

                   
        
