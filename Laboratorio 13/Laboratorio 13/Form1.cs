using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionstring = @"Server=MIRANDAS-DESKTO\SQLEXPRESS05;Database=Northwind;TrustServerCertificate=True;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT ProductName FROM Products ORDER BY ProductName ASC;";
            listBox1.Items.Clear();
 
                using (SqlConnection conexion = new SqlConnection(connectionstring))
                {
                    SqlCommand comando = new SqlCommand(query, conexion);
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                }
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}