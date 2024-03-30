﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="che.aspx.cs" Inherits="user_pyment_che" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="call.aspx" method="post">
        <script
            src="https://checkout.razorpay.com/v1/checkout.js"
            data-key="key"
            data-amount="<%=amount%>"
            data-name="<%=name%>"
            data-description="<%=product%>"
            data-order_id="<%=orderId%>"
            data-image="https://razorpay.com/favicon.png"
            data-buttontext="Pay with Razorpay"
            data-prefill.name="<%=name%>"
            data-prefill.email="<%=email%>"
            data-prefill.contact="<%=contact%>"
            data-theme.color="#F37254">
        </script>
    </form>

</body>
</html>
