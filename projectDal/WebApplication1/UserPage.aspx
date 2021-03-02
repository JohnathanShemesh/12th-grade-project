<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="WebApplication1.UserPage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1092px; width: 1900px;">
       
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 957px; top: 103px; position: absolute" Text="Create A Call" Font-Bold="True" Font-Size="30pt"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 15px; top: 37px; position: absolute; height: 15px;" Text="labal" Font-Bold="True" Font-Size="20pt" ></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 761px; top: 209px; position: absolute; margin-top: 0px;" Text="Choose A Date" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 762px; top: 434px; position: absolute; margin-top: 0px; height: 15px;" Text="Details" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="detailsText" runat="server" style="z-index: 1; left: 941px; top: 430px; position: absolute; height: 134px; width: 252px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="AddCallButton" runat="server" OnClick="AddCallButton_Click" style="z-index: 1; left: 998px; top: 747px; position: absolute; width: 140px; height: 40px;" Text="Add The Call" Font-Bold="True" Font-Size="15pt" />
        <p>
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
    <p>
        &nbsp;</p>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#33CC33" style="z-index: 1; left: 942px; top: 714px; position: absolute; width: 258px" Text="The call has been added to the system" Visible="False"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 943px; top: 206px; position: absolute; height: 164px; width: 259px" BackColor="White"></asp:Calendar>
        <asp:CheckBoxList ID="c" runat="server" style="z-index: 1; left: 998px; top: 603px; position: absolute; height: 23px; width: 183px; right: 370px" Font-Bold="True">
        </asp:CheckBoxList>
        <asp:Button ID="HomeButton" runat="server" OnClick="HomeButton_Click" style="z-index: 1; left: 25px; top: 85px; position: absolute; height: 45px; width: 141px" Text="Home Page" Font-Bold="True" Font-Size="15pt" />
   </div>
            </form>
    </body>
</html>
