<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormtest1.aspx.cs" Inherits="aspxfbex1.WebFormtest1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:palegreen;width:1200px;height:150px">
            <asp:TextBox ID="TextBox1" font-size="50px" width="1000px" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="设置时间" OnClick="Btnclk"/>
        </div>
    </form>
</body>
</html>
