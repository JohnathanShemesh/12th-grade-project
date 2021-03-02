<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebService.aspx.cs" Inherits="WebApplication2.WebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 505px; top: 130px; position: absolute; height: 164px; width: 259px"></asp:Calendar>
        <p>
        <asp:TextBox ID="detailsText" runat="server" style="z-index: 1; left: 504px; top: 333px; position: absolute; height: 134px; width: 252px" TextMode="MultiLine"></asp:TextBox>
        <asp:CheckBoxList ID="c" runat="server" style="z-index: 1; left: 587px; top: 506px; position: absolute; height: 23px; width: 139px; right: 579px">
        </asp:CheckBoxList>
        <asp:Button ID="AddCallButton" runat="server" OnClick="AddCallButton_Click" style="z-index: 1; left: 596px; top: 684px; position: absolute; width: 94px" Text="Add The Call" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 354px; top: 123px; position: absolute; margin-top: 0px;" Text="Choose A Date"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 366px; top: 335px; position: absolute; margin-top: 0px; height: 14px;" Text="Details"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 587px; top: 65px; position: absolute" Text="Create A Call"></asp:Label>
        </p>
    </form>
</body>
</html>
