﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aboutus.aspx.cs" Inherits="admin_aboutus" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <CKEditor:CKEditorControl ID="ckeditior" runat="server" BasePath="~/ckeditor/"></CKEditor:CKEditorControl>
        <asp:Button ID="btn_submit" runat="server" Text="Submit" 
            onclick="btn_submit_Click" />
        
    </div>  
    </form>
</body>
</html>
