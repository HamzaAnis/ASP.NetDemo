<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1SimpleCachedPage.aspx.cs" Inherits="_008_CacheManagement._1SimpleCachedPage" %>

<!-- Removing following will increase the session variable count -->
<%@ OutputCache Duration="10" Location="Server" VaryByParam="*" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        Session Variable will not be updated for cache duration ....
    </div>
    </form>
</body>
</html>
