<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
</head>
<body class="alert-info" >
       <form id="form1" runat="server">
                   <nav class="navbar navbar-inverse navbar-fixed-top" role="note">
      <div class="container" >
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
               <li><i class="icon-search"></i>
               </li>
            <li><a href="about.aspx">About</a></li>
            
              <li><a href="#contact">Contact</a></li>
              <li class ="topmenu"> <a style="height :21px"; href ="information"> <img src="photo/newicon.gif" /> Information</a></li>
              
              
               
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
   
    <div class="container" style="background-color:AppWorkspace!important">
        <div class="clearfix" style="margin-top:100px;"></div><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="medium"   ForeColor="Green"  ></asp:Label>
        <div class="row">
  <div class="col-md-3"style="background-color:black!important">

      <ul  class="nav nav-list">
       
          <li class="active" >
      <a href="OpenAccount.aspx" target="mw">Open Account</a>
          </li> <hr />  
           <li class="active" > <a href="BranchDetails.aspx" target="mw">Add Branch</a>
               </li><hr /><li class="active"> <a href="Deposite.aspx" target="mw">Deposite</a>
                </li><hr /><li class="active"><a href="Widrowl.aspx" target="mw">Withdrawl</a>
                </li><hr /><li class="active"><a href="FixedDeposite.aspx" target="mw">Fixed Deposite</a>
                </li><hr /><li class="active"><a href="LoanInformation.aspx" target="mw">Loan Information</a>
                </li><hr /><li class="active"><a href="Transaction.aspx" target="mw">Transfer Amount</a>
                  </li><hr /> <li class="active"><a href="Search.aspx" target="mw">Search Record</a></li></ul>
     
      

      <img src="photo/unnamed%20(3).jpg"  width="100%" />
      
      

  </div>
  <div class="col-md-9"><iframe frameborder="0" height="670" width="60%" name="mw" valign="top" ></iframe></div>
</div>
       
    
   
       
         </div>

    
   
         
        
    </form>
    </body>
</html>
        
