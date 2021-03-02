<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkerRegister.aspx.cs" Inherits="WebApplication1.WorkerRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1090px; width: 1925px;">
    
  
        <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 882px; top: 230px; position: absolute; width: 202px" Text="Tell Us About Yourself" Font-Size="15pt"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 720px; top: 358px; position: absolute; height: 16px;" Text="Describe Yourself"></asp:Label>
        <asp:TextBox ID="xpText" runat="server" style="z-index: 1; left: 930px; top: 292px; position: absolute; margin-bottom: 0px" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="desText" runat="server" style="z-index: 1; left: 929px; top: 357px; position: absolute; height: 106px; width: 234px" TextMode="MultiLine"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 720px; top: 295px; position: absolute" Text="Years Of Expirience"></asp:Label>
            <asp:TextBox ID="locText" runat="server" style="z-index: 1; left: 929px; top: 519px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 724px; top: 522px; position: absolute" Text="Location"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 935px; top: 745px; position: absolute" Text="Submit" Font-Bold="True" Font-Size="15pt" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="z-index: 1; left: 927px; top: 583px; position: absolute; height: 26px; width: 111px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
        </asp:CheckBoxList>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
   </div>
        </form>
</body>
</html>
