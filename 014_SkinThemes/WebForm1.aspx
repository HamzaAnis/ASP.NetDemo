<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_014_SkinThemes.WebForm1" StyleSheetTheme="Theme1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <br />
        <!-- I like default theme for the following item -->
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
         <!-- I like different theme for the following item -->
        <asp:TextBox ID="TextBox3" runat="server" SkinID="greentext"></asp:TextBox><br /><br />
         <!-- theme is false -->
         <asp:TextBox ID="TextBox4" runat="server"  BackColor="#99CCFF"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" />

    </div>
    </form>
</body>
</html>
