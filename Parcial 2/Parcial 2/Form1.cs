using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 
using System.Globalization; 

namespace Parcial_2
{
    public partial class fmConversor : Form
    {

        private const decimal FACTOR_GALON_A_LITRO = 3.78541m;


        private readonly string _connectionString = @"Server=MIRANDAS-DESKTO\SQLEXPRESS05;Database=Parcial2Conversor;Integrated Security=True;";

        public fmConversor()
        {
            InitializeComponent();
            txtLG.ReadOnly = true;
        }



        private void btnGL_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtGalones.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal galones))
            {

                decimal litros = galones * FACTOR_GALON_A_LITRO;

                txtGL.Text = litros.ToString("F4", CultureInfo.InvariantCulture);


                GuardarConversion("Galones a Litros", galones, litros);
            }
            else
            {

                MessageBox.Show("Por favor, ingrese un número válido en Galones.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGalones.Focus();
            }
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtLitros.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal litros))
            {

                decimal galones = litros / FACTOR_GALON_A_LITRO;

                txtLG.Text = galones.ToString("F4", CultureInfo.InvariantCulture);

                GuardarConversion("Litros a Galones", litros, galones);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido en Litros.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLitros.Focus();
            }
        }

        // --- MÉTODO DE ACCESO A DATOS ---

        /// <summary>
        /// Guarda un registro de conversión en la base de datos.
        /// </summary>
        /// <param name="tipo">Ej: "Galones a Litros"</param>
        /// <param name="valorOriginal">El número que ingresó el usuario</param>
        /// <param name="valorConvertido">El resultado del cálculo</param>
        private void GuardarConversion(string tipo, decimal valorOriginal, decimal valorConvertido)
        {

            string query = "INSERT INTO Historial (TipoConversion, ValorOriginal, ValorConvertido) " +
                           "VALUES (@Tipo, @Original, @Convertido)";


            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Tipo", tipo);
                        cmd.Parameters.AddWithValue("@Original", valorOriginal);
                        cmd.Parameters.AddWithValue("@Convertido", valorConvertido);


                        conn.Open();


                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show($"Error al guardar en la base de datos:\n{ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ha ocurrido un error inesperado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtGalones_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGalones.Text))
            {
                txtLitros.Clear();
                txtLG.Clear();
            }
        }

        private void txtLitros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLitros.Text))
            {
                txtGalones.Clear();
                txtGL.Clear();
            }
        }

        private void txtGL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form2 frmHistorial = new Form2();

            
            frmHistorial.Show();

            
        }
    }
}