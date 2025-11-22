<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab20_2.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Matriz Diagonal Inversa</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; }
        .container { border: 1px solid #ccc; padding: 20px; border-radius: 8px; width: 400px; }
        
        /* Estilos para la tabla */
        table.matriz { border-collapse: collapse; margin-top: 15px; margin-left: auto; margin-right: auto; }
        table.matriz td { border: 1px solid #333; padding: 10px; text-align: center; width: 30px; height: 30px; }
        
        /* Color verde para los 1s */
        .uno { background-color: #dff0d8; font-weight: bold; color: green; } 
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Generador de Matriz (N x N)</h2>
            <p>Ingrese la dimensión N:</p>
            
            <asp:TextBox ID="txtDimension" runat="server" Type="number" Width="100px"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" />
            
            <br /><br />
            
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            
            <asp:Literal ID="litTabla" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>