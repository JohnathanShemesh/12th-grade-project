<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RatingPage.aspx.cs" Inherits="WebApplication1.RatingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type ="text/css" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1214px; width: 1920px;">
    
        
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="50pt" Font-Strikeout="False" style="z-index: 1; left: 619px; top: 273px; position: absolute; height: 61px; width: 381px" Text="Rate The Job"></asp:Label>        
        <asp:ImageButton ID="star1" runat="server" Height="43px" ImageUrl="~/Resources/hollowstar.png" OnClick="star1_Click" style="z-index: 1; left: 617px; top: 374px; position: absolute; right: 803px;" Width="71px" />
        <asp:ImageButton ID="star2" runat="server" Height="43px" ImageUrl="~/Resources/hollowstar.png" OnClick="star2_Click" style="z-index: 1; left: 697px; top: 374px; position: absolute" Width="71px" />
        <asp:ImageButton ID="star3" runat="server" Height="43px" ImageUrl="~/Resources/hollowstar.png" OnClick="star3_Click" style="z-index: 1; left: 775px; top: 373px; position: absolute" Width="71px" />
        <asp:ImageButton ID="star4" runat="server" Height="43px" ImageUrl="~/Resources/hollowstar.png" OnClick="star4_Click" style="z-index: 1; left: 852px; top: 374px; position: absolute" Width="71px" />
        <asp:ImageButton ID="star5" runat="server" Height="43px" ImageUrl="~/Resources/hollowstar.png" OnClick="star5_Click" style="z-index: 1; left: 925px; top: 375px; position: absolute" Width="71px" />
        <asp:Button ID="SubmitButton" runat="server" style="z-index: 1; left: 751px; top: 542px; position: absolute; height: 50px; width: 116px;" Text="Submit" OnClick="SubmitButton_Click" Font-Bold="True" Font-Size="20pt" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 668px; top: 439px; position: absolute; height: 69px; width: 273px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="20pt" OnClick="Button1_Click" style="z-index: 1; left: 21px; top: 84px; position: absolute; height: 57px; width: 176px" Text="Home Page" />
    </div>
        </form>
</body>
</html>
