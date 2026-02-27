using System;
using System.Data;
using System.Data.SqlClient; 
using System.Web.UI;

namespace Lab20_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        string connectionString = "Data Source=.;Initial Catalog=Laboratorio14;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Estudiantes (Nombre, Edad) VALUES (@p1, @p2)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@p1", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@p2", int.Parse(txtDato.Text));

                    cmd.ExecuteNonQuery();
                }

                lblMensaje.Text = "¡Guardado correctamente!";
                lblMensaje.ForeColor = System.Drawing.Color.Green;


                txtNombre.Text = "";
                txtDato.Text = "";
                CargarDatos();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void CargarDatos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = "SELECT * FROM Estudiantes";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gridDatos.DataSource = dt;
                    gridDatos.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "No se pudo cargar la lista (Revisa la cadena de conexión).";
            }
        }
    }
}