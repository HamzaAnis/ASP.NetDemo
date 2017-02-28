<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="_004_StateManagement.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Update View State Variable" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" Text="Update Session State Variable" OnClick="Button2_Click" />
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button3" runat="server" Text="Update Application State Variable" OnClick="Button3_Click" />
    <div>
    
    </div>
    </form>
</body>
</html>
