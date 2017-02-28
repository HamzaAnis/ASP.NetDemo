<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_013_UserControls.Home" %>

<%@ Register src="MyUserControl.ascx" tagname="MyUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:MyUserControl ID="MyUserControl1" runat="server" />
        <br />
        <br />
        <uc1:MyUserControl ID="MyUserControl2" runat="server"  FColor="#000099"/>
    
    </div>
    </form>
</body>
</html>
