﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="f_pass.aspx.cs" Inherits="user_login_f_pass" %>




<!--A Design by W3layouts
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="en">

<head>
	<title>CAR SERIVES | Forgot Password</title>
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
</head>

<body>
<form id="Form1" runat="server">
	<h1  class="header-w3ls">
		Password Recovery</h1>
        
			<div class="mid-cls">


<div class="swm-right-w3ls">
 <form action="#" method="post">
 			<div class="main">
				<div class="icon-head-wthree">
        <%--<h2><span class="fa fa-diamond t-w3" aria-hidden="true"></span></h2>--%>
		<h4>Reset Password</h4>
		</div>
         <div class="form-left-to-w3l">
             
		     
             <asp:TextBox ID="txtemail" placeholder="Enter Ragistered Email" runat="server"></asp:TextBox>
			
          <div class="clear"></div> 
		</div> 		   
		 
	     <div class="btnn">

	          
             <asp:button ID="btn_continue" Text="Continue"  runat="server" style=" width: 100%;
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
    -ms-transition: 0.5s all;" onclick="btn_continue_Click" /><br>

       	     
       	      
        </div>	
     </div>
     <ul>
						<a href="login_signup.aspx" style=" width: 100%;color:red" >Log-In</a> |
						<a href="login_signup.aspx" style="width: 100%;color:#f10b59;" >Sign-Up</a>
						
					</ul> 
   </form>

</div>
</div>
			<div class="copy">
		<p>&copy;2018 R & M. All Rights Reserved | Design by </p>
	</div>
    </form>
</body>
</html>
