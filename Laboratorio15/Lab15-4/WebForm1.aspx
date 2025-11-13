<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Introduzca dos numeros que quiera sumar<br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="71px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="+"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="84px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Resultado" />
            <asp:Label ID="LabelResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
