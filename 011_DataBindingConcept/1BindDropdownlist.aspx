<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1BindDropdownlist.aspx.cs" Inherits="_011_DataBindingConcept._1BindDropdownlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" DataSource ="<%# arrData %>">
        </asp:DropDownList> <br /><br />

        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
