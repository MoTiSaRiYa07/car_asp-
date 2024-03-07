<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="user_login_Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>H  K | Login | Sign-Up </title>
	<!-- Meta tags -->
	<meta name="viewport" content="width=device-width, initial-scale=1" />
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="keywords" content="Stunning sign up & login Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
	/>
	<script>
	    addEventListener("load", function () { setTimeout(hideURLbar, 0); }, false); function hideURLbar() { window.scrollTo(0, 1); }
    </script>
	<!-- Meta tags -->
		<!-- font-awesome icons -->
	<link rel="stylesheet" href="css/font-awesome.min.css" />
	<!-- //font-awesome icons -->
	<!--stylesheets-->
	<link href="css/style.css" rel='stylesheet' type='text/css' media="all">
	<!--//style sheet end here-->

<link href="//fonts.googleapis.com/css?family=Montserrat:300,400,500,600" rel="stylesheet">
     <style>

     .for1
     {
         text-align:center;
         color:red;
          width: 100px;
          height: 100px;
           animation-duration: 4s;
          transform-style:flat;
     }
 </style>
</head>
    
<body>
    <form runat="server">
	<h1  class="header-w3ls">
			CAR SERVICE</h1>
        
			<div class="mid-cls">
<div class="swm-left-w3ls">
				
			<div class="main">
			<div class="icon-head-wthree">
			      
        <%--<h2><span class="fa fa-diamond t-w3" aria-hidden="true"></span></h2>--%>
		<h4>Login</h4>
		</div>
         <div class="form-left-to-w3l">
             
		     
             <asp:TextBox ID="txt_email" placeholder="Email" runat="server"></asp:TextBox>
			
          <div class="clear"></div> 
		</div> 		   
		 <div class="form-left-to-w3l">
				
				
             <asp:TextBox ID="txt_pass" placeholder="Password"    TextMode="Password"  runat="server" style=" width: 100%;
    color: #000;
    outline: none;
    font-size: 14px;
    padding: .6em .7em;
    margin: 0px 0px 23px;
    border:none;
    -webkit-appearance: none;
    display: inline-block;
    background: rgb(255, 255, 255);
    transition: all 0.5s ease-in-out;
    -webkit-transition: all 0.5s ease-in-out;
    -moz-transition: all 0.5s ease-in-out;
    -o-transition: all 0.5s ease-in-out;
    -ms-transition: all 0.5s ease-in-out;
    box-sizing: border-box;"></asp:TextBox>
			
		         <div class="clear"></div>
		</div>
	     <div class="btnn">

	          
             <asp:button ID="btn_login" Text="Login"  runat="server" style=" width: 100%;
    background:#f10b59;
    outline: none;
    color: #fff;
    font-size: 13px;
    border: 1px solid #fff;
    padding: 9px 6px;
    letter-spacing: 1px;
    text-transform: uppercase;
    cursor: pointer;
    transition: 0.5s all;
    -webkit-transition: 0.5s all;
    -o-transition: 0.5s all;
    -moz-transition: 0.5s all;
    -ms-transition: 0.5s all;" OnClick="btn_login_Click"></asp:button>
    <br>

       	      <a href="f_pass.aspx" class="for" >Forgot password...?</a>  
       	      
        </div>	
     </div>

    
           <a href="login_signup.aspx" class="for1" >SIGNUP NOW </a>
  

</div>
</div>
			<div class="copy">
		<p>&copy;CAR SERVICE MANGMENT SYSTEM</p>
	</div>
    </form>
</body>
</html>
