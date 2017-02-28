<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage2.aspx.cs" Inherits="_003_PageLifeCycle.TestPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p> This page uses resource file to display some messages</p>
        <!-- Resources should be placed in App_GlobalResources -->
        <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Resource1, Hello%>"></asp:Label>
         
    </div>
    </form>
</body>
</html>
