<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestControls.aspx.cs" Inherits="_009_ServerSideControls.TestControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True"  /><br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem Value="1">oranges</asp:ListItem>
            <asp:ListItem Value="2">Apples</asp:ListItem>
            <asp:ListItem Value="3">Banana</asp:ListItem>
        </asp:CheckBoxList><br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Lahore</asp:ListItem>
            <asp:ListItem>Islamabad</asp:ListItem>
            <asp:ListItem>Peshawar</asp:ListItem>
        </asp:DropDownList><br />
        <asp:HiddenField ID="HiddenField1" runat="server" /><br />
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink><br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/book.jpg" /><br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/book.jpg" OnClick="ImageButton1_Click" /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton><br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" ToolTip="test tool tip property">
            <asp:ListItem>aaaaa</asp:ListItem>
            <asp:ListItem>bbbb</asp:ListItem>
            <asp:ListItem>cccccc</asp:ListItem>
        </asp:ListBox><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
    </div>
    </form>
</body>
</html>
