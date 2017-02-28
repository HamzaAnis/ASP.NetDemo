<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation.aspx.cs" Inherits="_003_PageLifeCycle.Navigation"  %>
<!-- EnableViewStateMac is set to flase to use preserve state -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="TestPage2.aspx"> Next Page</a>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Execute" OnClick="Button1_Click" />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Transfer" OnClick="Button2_Click" />
    <br />
    <asp:HyperLink id="HyperLink1" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 80px"
				runat="server" NavigateUrl="~/Navigation2.aspx">Another Form</asp:HyperLink>
    <input style="Z-INDEX: 107; LEFT: 288px; POSITION: absolute; TOP: 112px" onclick = "window.open('Navigation2.aspx')" type="button" value="Open"/>
    </div>
    </form>
</body>
</html>
