<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkerPage.aspx.cs" Inherits="WebApplication1.WorkerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1092px; width: 1923px;">
    
   
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 795px; top: 377px; position: absolute; height: 268px; width: 452px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="20pt"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 956px; top: 768px; position: absolute" Visible="False"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 954px; top: 824px; position: absolute" Text="Report The Call" Visible="False" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 911px; top: 714px; position: absolute" Text="Tell us what is wrong with the call" Visible="False"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="15pt" style="z-index: 1; left: 816px; top: 314px; position: absolute; bottom: 681px" Text="If you want to report a call, click the select button"></asp:Label>
   </div>
        </form>
</body>
</html>
