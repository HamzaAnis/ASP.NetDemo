<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage1.aspx.cs" Inherits="_003_PageLifeCycle.TestPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%: S %>
        <br />
        <a href="TestPage2.aspx"> Next Page</a>
        <br />
        <a href="QueryString.aspx?x=100&y=50&z=hello"> Query String Test</a>
       
    </div>
    </form>
</body>
</html>
