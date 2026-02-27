using System;
using System.Text;
using System.Web.UI;

namespace Lab20_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; // Limpiar errores

            // Validar que sea un número y mayor a 0
            if (int.TryParse(txtDimension.Text, out int n) && n > 0)
            {
                StringBuilder html = new StringBuilder();

                html.Append("<table class='matriz'>");

                // Ciclo Filas (i)
                for (int i = 0; i < n; i++)
                {
                    html.Append("<tr>");

                    // Ciclo Columnas (j)
                    for (int j = 0; j < n; j++)
                    {
                        // Lógica Diagonal Inversa: i + j = n - 1
                        if ((i + j) == (n - 1))
                        {
                            html.Append("<td class='uno'>1</td>");
                        }
                        else
                        {
                            html.Append("<td>0</td>");
                        }
                    }
                    html.Append("</tr>");
                }

                html.Append("</table>");

                // Mostrar la tabla
                litTabla.Text = html.ToString();
            }
            else
            {
                lblError.Text = "Por favor, ingrese un número entero válido mayor a 0.";
                litTabla.Text = "";
            }
        }
    }
}