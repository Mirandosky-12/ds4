<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GestionCasosLegales.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Casos Legales</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-container">
            <h2>Registro de Caso Legal</h2>
            

            <div class="row">
                <div class="col form-group">
                    <label>Título del Caso:</label>
                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="input-field" placeholder="Ej: Demanda X vs Y"></asp:TextBox>
                </div>
                <div class="col form-group">
                    <label>Cliente:</label>
                    <asp:TextBox ID="txtCliente" runat="server" CssClass="input-field" placeholder="Nombre del cliente"></asp:TextBox>
                </div>
            </div>


            <div class="row">
                <div class="col form-group">
                    <label>Abogado Asignado:</label>
                    <asp:DropDownList ID="ddlAbogado" runat="server" CssClass="input-field">
                        <asp:ListItem Text="-- Seleccione --" Value="" />
                        <asp:ListItem Text="Lic. Santiago" Value="Lic. Santiago" />
                        <asp:ListItem Text="Lic. Herrera" Value="Lic. Herrera" />
                        <asp:ListItem Text="Lic. Gomez" Value="Lic. Gomez" />
                    </asp:DropDownList>
                </div>
                <div class="col form-group">
                    <label>Estado del Caso:</label>
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="input-field">
                        <asp:ListItem Text="Nuevo" Value="Nuevo" />
                        <asp:ListItem Text="En Proceso" Value="En Proceso" />
                        <asp:ListItem Text="En Espera" Value="En Espera" />
                        <asp:ListItem Text="Cerrado" Value="Cerrado" />
                    </asp:DropDownList>
                </div>
            </div>

            <div class="row">
                <div class="col form-group">
                    <label>Fecha de Inicio:</label>
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="input-field" TextMode="Date"></asp:TextBox>
                </div>
                <div class="col form-group">
                    <label>Fecha de Vencimiento:</label>
                    <asp:TextBox ID="txtFechaVencimiento" runat="server" CssClass="input-field" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Descripción / Notas:</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="input-field" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>

            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Caso" CssClass="btn" OnClick="btnRegistrar_Click" />
            
            <asp:Label ID="lblMensaje" runat="server" CssClass="message"></asp:Label>

            <hr />

            <h3>Casos Registrados</h3>
            <asp:GridView ID="gvCasos" runat="server" CssClass="grid-view" AutoGenerateColumns="true" EmptyDataText="No hay casos registrados.">
            </asp:GridView>

        </div>
    </form>
</body>
</html>