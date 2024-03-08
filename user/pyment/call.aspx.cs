﻿using iText.Layout.Borders;
using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_pyment_call : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string paymentId = Request.Form["razorpay_payment_id"];
            //string orderId = Request.Form["razorpay_order_id"];
            string signature = Request.Form["razorpay_signature"];

            string key = "rzp_test_FlW43SxAjeEjSl";
            string secret = "fKyl37tFaQftg9vjbUEctdGx";

            RazorpayClient client = new RazorpayClient(key, secret);

            Dictionary<string, string> attributes = new Dictionary<string, string>();

            attributes.Add("razorpay_payment_id", paymentId);
            //attributes.Add("razorpay_order_id", orderId);
            attributes.Add("razorpay_signature", signature);

            Utils.verifyPaymentSignature(attributes);
            pTxnId.InnerText = paymentId;
            //pOrderId.InnerText = orderId;
            h1Message.InnerText = "Transaction Successfull";
        }
        catch (Exception)
        {
            h1Message.InnerText = "Transaction Unsuccessfull";
        }
    }
}
    
