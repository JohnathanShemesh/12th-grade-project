<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkerList.aspx.cs" Inherits="WebApplication1.WorkerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1093px; width: 1916px;">
    
   
        <asp:DropDownList ID="d" runat="server" style="z-index: 1; left: 966px; top: 324px; position: absolute; height: -5px;" AutoPostBack="True" OnSelectedIndexChanged="d_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 712px; top: 412px; position: absolute; height: 313px; width: 594px" AutoGenerateSelectButton="True" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellSpacing="4" OnRowDataBound="GridView1_RowDataBound" BackColor="White">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 954px; top: 814px; position: absolute" Text="Home Page" />
   </div>
        </form>
</body>
</html>
