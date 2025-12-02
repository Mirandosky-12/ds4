using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; 

namespace GestionCasosLegales
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        string connectionString = "Data Source=.;Initial Catalog=DiegoLopez;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCasos();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblMensaje.Text = "Por favor complete los campos obligatorios.";
                lblMensaje.CssClass = "message error";
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = "INSERT INTO DL_CasosLegales (TituloCaso, NombreCliente, AbogadoAsignado, Estado, FechaInicio, FechaVencimiento, Descripcion) " +
                                   "VALUES (@Titulo, @Cliente, @Abogado, @Estado, @Inicio, @Vence, @Desc)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                        cmd.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                        cmd.Parameters.AddWithValue("@Abogado", ddlAbogado.SelectedValue);
                        cmd.Parameters.AddWithValue("@Estado", ddlEstado.SelectedValue);
                        cmd.Parameters.AddWithValue("@Inicio", DateTime.Parse(txtFechaInicio.Text));

                        if (string.IsNullOrEmpty(txtFechaVencimiento.Text))
                            cmd.Parameters.AddWithValue("@Vence", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Vence", DateTime.Parse(txtFechaVencimiento.Text));

                        cmd.Parameters.AddWithValue("@Desc", txtDescripcion.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                lblMensaje.Text = "¡Caso registrado exitosamente!";
                lblMensaje.CssClass = "message success";
                LimpiarCampos();
                CargarCasos();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al registrar: " + ex.Message;
                lblMensaje.CssClass = "message error";
            }
        }

        private void CargarCasos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM DL_CasosLegales ORDER BY FechaInicio DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvCasos.DataSource = dt;
                    gvCasos.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar datos: " + ex.Message;
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtCliente.Text = "";
            txtDescripcion.Text = "";
            ddlAbogado.SelectedIndex = 0;
            ddlEstado.SelectedIndex = 0;
            txtFechaInicio.Text = "";
            txtFechaVencimiento.Text = "";
        }
    }
}