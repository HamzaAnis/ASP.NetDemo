﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="disableviewstate.aspx.cs" Inherits="_004_StateManagement.disableviewstate"  EnableViewState="false"%>

<!-- I have changed EnableViewState="false" in page directive -->

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
    </div>
    </form>
</body>
</html>
