<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio20.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tabla de Multiplicar</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; }
        .container { border: 1px solid #ccc; padding: 20px; border-radius: 8px; width: 300px; }
        .resultado { margin-top: 15px; font-family: 'Courier New', Courier, monospace; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Tabla de Multiplicar (hasta el 25)</h2>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Ingrese un número:"></asp:Label>
                <br />
                <asp:TextBox ID="txtNumero" runat="server" Width="200px" Type="number"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnCalcular" runat="server" Text="Mostrar Tabla" OnClick="btnCalcular_Click" />
            </div>
            
            <div class="resultado">
                <%-- Aquí se mostrará la tabla de multiplicar --%>
                <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
