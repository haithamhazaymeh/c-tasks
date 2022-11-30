<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="calculator.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="number1"></asp:Label> 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="number2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>


            <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="/" OnClick="Button4_Click" /> <br />

            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
