<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerPage.aspx.cs" Inherits="WebApplication1.ManagerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1084px;">
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 502px; top: 146px; position: absolute; height: 460px; width: 535px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White">
        </asp:GridView>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40pt" style="z-index: 1; left: 433px; top: 31px; position: absolute" Text="Welcome to the maneger's page"></asp:Label>
                    </div>

    </form>
</body>
</html>
