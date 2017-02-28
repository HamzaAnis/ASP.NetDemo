<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2BindGrid.aspx.cs" Inherits="_011_DataBindingConcept._2BindGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSource="<%# dataSet1 %>">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
