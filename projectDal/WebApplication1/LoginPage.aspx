<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style ="background-image: url('images/Blue-Backgrounds-HD-Wallpaper-Cave.png'); height: 1098px; width: 1920px; margin-top: 0px;">
    
   
        <asp:TextBox ID="Password" runat="server" style="z-index: 1; left: 848px; top: 451px; position: absolute; width: 311px; height: 39px;" TextMode="Password" Font-Size="20pt"></asp:TextBox>
        <asp:TextBox ID="Email" runat="server" style="z-index: 1; left: 848px; top: 355px; position: absolute; width: 309px; height: 39px;" TextMode="Email"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 910px; top: 225px; position: absolute" Text="Login" Font-Bold="True" Font-Size="60pt"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 585px; top: 356px; position: absolute; height: 35px; width: 99px; bottom: 247px;" Text="Email" Font-Size="30pt"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; top: 456px; position: absolute; left: 581px; height: 13px;" Text="Password" Font-Size="30pt"></asp:Label>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 913px; top: 648px; position: absolute; width: 207px; height: 76px;" Text="Submit" Font-Bold="True" Font-Size="35pt" />
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" style="z-index: 1; left: 849px; top: 549px; position: absolute" NavigateUrl="~/RegisterPage.aspx" Font-Size="20pt">Don&#39;t have a user? Create one!</asp:HyperLink>
     </div>
        </form>

</body>
</html>
