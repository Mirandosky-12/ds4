using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// --- LIBRERÍAS AÑADIDAS ---
using System.Data.SqlClient; // Para interactuar con SQL Server
using System.Globalization; // Para formatear números

namespace Parcial_2
{
    public partial class Form2 : Form
    {
        private readonly string _connectionString = @"Server=MIRANDAS-DESKTO\SQLEXPRESS05;Database=Parcial2Conversor;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();
            CargarHistorial();
        }

        /// <summary>
        ///
        /// </summary>
        private void CargarHistorial()
        {

            lstHistorial.Items.Clear();

            string query = "SELECT TipoConversion, ValorOriginal, ValorConvertido, Fecha " +
                           "FROM Historial ORDER BY Fecha DESC";

            try
            {

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        conn.Open();


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (!reader.HasRows)
                            {
                                lstHistorial.Items.Add("No hay historial de conversiones.");
                                return; 
                            }


                            while (reader.Read())
                            {

                                string tipo = reader["TipoConversion"].ToString();
                                decimal original = (decimal)reader["ValorOriginal"];
                                decimal convertido = (decimal)reader["ValorConvertido"];
                                DateTime fecha = (DateTime)reader["Fecha"];

                                string item = string.Format(CultureInfo.InvariantCulture,
                                    "{0:yyyy-MM-dd HH:mm} | {1} | {2:F4} -> {3:F4}",
                                    fecha,
                                    tipo,
                                    original,
                                    convertido);

                           
                                lstHistorial.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el historial desde la BD:\n{ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstHistorial.Items.Add("Error al cargar el historial.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}