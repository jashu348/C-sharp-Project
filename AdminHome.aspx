<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
         <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">Crime Tracking System</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="#">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#contact">Contact</a></li>
              <li><a href="#"> </a></li>
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
   </div>
    <div class="container">
        <div class="clearfix" style="margin-top:100px;"></div><asp:Label ID="Label1" runat="server"></asp:Label>
        <div class="row">
  <div class="col-md-3">
      <ul  class="nav nav-pills nav-stacked"><li>
      <a href="state.aspx" target="mw">Add State</a>
          </li>    
           <li class="active"> <a href="city.aspx" target="mw">Add City</a>
               </li><li> <a href="block.aspx" target="mw">Add Block</a>
                </li><li><a href="Station.aspx" target="mw">Police Station Register</a>
                </li><li><a href="Employee.aspx" target="mw">Employee Register</a>
                </li><li><a href="Fir.aspx" target="mw">Fir Register</a>
                </li><li><a href="Criminal.aspx" target="mw">Criminal Register</a>
                  </li> <li><a href="Search.aspx" target="mw">Search Record</a></li></ul></div>
  <div class="col-md-9"><iframe  class="col-md-9" frameborder="0" height="600" name="mw" valign="top"></iframe></div>
</div>
       
    
   
       
         </div>
    </form>
    </body>
</html>
