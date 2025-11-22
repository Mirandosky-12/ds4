<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab20_3.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Laboratorio 20-3 (Base de Datos)</title>
    <style>
        body { font-family: 'Segoe UI', Arial, sans-serif; margin: 20px; background-color: #f4f4f4; }
        .main-container { background-color: white; padding: 30px; border-radius: 10px; box-shadow: 0 0 10px rgba(0,0,0,0.1); width: 600px; margin: auto; }
        h2 { color: #333; }
        .form-group { margin-bottom: 15px; }
        label { display: block; font-weight: bold; margin-bottom: 5px; }
        .input-field { padding: 8px; width: 100%; box-sizing: border-box; border: 1px solid #ccc; border-radius: 4px; }
        .btn { background-color: #007bff; color: white; padding: 10px 20px; border: none; border-radius: 4px; cursor: pointer; }
        .btn:hover { background-color: #0056b3; }
        .grid-view { width: 100%; margin-top: 20px; border-collapse: collapse; }
        .grid-view th { background-color: #007bff; color: white; padding: 10px; }
        .grid-view td { padding: 8px; border: 1px solid #ddd; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-container">
            <h2>Registro (Simulación Lab 14)</h2>
            
            <%-- Formulario de Ingreso --%>
            <div class="form-group">
                <label>Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="input-field"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <label>Edad (o Dato Numérico):</label>
                <asp:TextBox ID="txtDato" runat="server" CssClass="input-field" Type="number"></asp:TextBox>
            </div>

            <asp:Button ID="btnGuardar" runat="server" Text="Guardar Datos" CssClass="btn" OnClick="btnGuardar_Click" />
            
            <br /><br />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

            <hr />

            <h3>Lista de Datos en BD</h3>
            <%-- Tabla para mostrar datos --%>
            <asp:GridView ID="gridDatos" runat="server" CssClass="grid-view" AutoGenerateColumns="true">
            </asp:GridView>
        </div>
    </form>
</body>
</html>