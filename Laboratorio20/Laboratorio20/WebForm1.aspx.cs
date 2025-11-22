using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Puedes poner código que se ejecute al cargar la página aquí
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Validar la entrada
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // 2. Usar un StringBuilder para construir el texto de la tabla
                // Es más eficiente que concatenar strings (+) en un bucle.
                StringBuilder tablaHtml = new StringBuilder();

                // 3. Generar la tabla del 1 al 25
                for (int i = 1; i <= 25; i++)
                {
                    int resultado = numero * i;
                    // Agregamos cada línea al StringBuilder con un salto de línea HTML (<br />)
                    tablaHtml.AppendFormat("{0} x {1} = {2}<br />", numero, i, resultado);
                }

                // 4. Mostrar el resultado en el Label
                lblResultado.Text = tablaHtml.ToString();
                lblResultado.ForeColor = System.Drawing.Color.Black; // Color normal
            }
            else
            {
                // Mensaje de error si no se ingresó un número válido
                lblResultado.Text = "Por favor, ingrese un número entero válido.";
                lblResultado.ForeColor = System.Drawing.Color.Red; // Color rojo para error
            }
        }
    }
}