<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height:1190px; width:1960px;">
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [DateCall], [Details], [IDCall] FROM [WorkCall]"></asp:SqlDataSource>
        <asp:Button ID="NoButton" runat="server" BackColor="White" BorderStyle="None" Enabled="False" Font-Size="Smaller" ForeColor="#999999" style="z-index: 1; left: 998px; top: 651px; position: absolute; width: 68px; right: 596px; height: 17px;" Text="No Thanks" Visible="False" OnClick="NoButton_Click" Font-Bold="True" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 876px; top: 705px; position: absolute" Text="Create A Call" Font-Bold="True" Font-Size="20pt" />
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="20pt"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" Height="261px" style="z-index: 1; left: 733px; top: 264px; position: absolute; height: 261px; width: 527px" Width="527px" BackColor="White">
            <Columns>
                <asp:CommandField ButtonType="Button" SelectText="Delete" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="RateButton" runat="server" Enabled="False" OnClick="RateButton_Click" style="z-index: 1; left: 931px; top: 645px; position: absolute; right: 690px;" Text="Rate" Visible="False" Font-Bold="True" />
        <asp:Label ID="RateLabel" runat="server" style="z-index: 1; left: 888px; top: 586px; position: absolute" Text="Do You Want To Rate The Job?" Visible="False"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 505px; top: 305px; position: absolute" Text="You Don't Have Any Calls" Visible="False"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 11px; top: 183px; position: absolute; width: 162px; height: 43px;" Text="Workers List" Font-Bold="True" Font-Size="15pt" />
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="50pt" style="z-index: 1; left: 840px; top: 143px; position: absolute" Text="Your Calls"></asp:Label>
     </div>
            </form>
</body>
</html>
