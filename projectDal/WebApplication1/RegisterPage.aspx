<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="WebApplication1.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1090px; width: 1920px;">
    
   
        <asp:TextBox ID="Password" runat="server" style="z-index: 1; left: 909px; top: 421px; position: absolute; margin-top: 1px; margin-bottom: 5px;" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="Email" runat="server" style="z-index: 1; left: 908px; top: 369px; position: absolute" TextMode="Email"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 903px; top: 491px; position: absolute" Text="Are you a worker?" OnCheckedChanged="CheckBox1_CheckedChanged" Font-Bold="True" />
        <p>
            &nbsp;</p>
        <asp:TextBox ID="FullName" runat="server" style="z-index: 1; left: 908px; top: 320px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 770px; top: 422px; position: absolute; right: -145px" Text="Password" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 776px; top: 372px; position: absolute" Text="Email" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 776px; top: 322px; position: absolute; margin-top: 0px; height: 16px;" Text="Full Name" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 849px; top: 203px; position: absolute; height: 63px;" Text="Register" Font-Bold="True" Font-Size="50pt"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 927px; top: 553px; position: absolute; width: 97px; height: 37px;" Text="Submit" Font-Bold="True" Font-Size="15pt" />
    </div>
        </form>
</body>
</html>
