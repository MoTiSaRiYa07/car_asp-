<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pyment.aspx.cs" Inherits="user_pyment_Pyment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h1>Registration</h1>
<div>
    <div class="row">
        <div class="col-md-offset-1 col-md-2">
            <asp:Label runat="server" Text="Name" />
        </div>
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
        </div>
    </div>
   <%-- <div class="row">
        <div class="col-md-offset-1 col-md-2">
            <asp:Label runat="server" Text="Mobile" />
        </div>
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="txtMobile" CssClass="form-control" />
        </div>
    </div>--%>
    <div class="row">
        <div class="col-md-offset-1 col-md-2">
            <asp:Label runat="server" Text="Email" />
        </div>
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-offset-1 col-md-2">
            <asp:Label runat="server" Text="Amount" />
        </div>
        <div class="col-md-4">
            <asp:TextBox runat="server" ID="txtAmount" CssClass="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 text-right">
            <asp:Button runat="server" ID="btnRegister" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click"/>
        </div>
    </div>
</div>
 </form>
</body>
</html>
