using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No se necesita código aquí para este laboratorio
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // No se necesita código aquí para este laboratorio
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // No se necesita código aquí para este laboratorio
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1. Declarar variables para guardar los números
            double num1 = 0;
            double num2 = 0;

            // 2. Intentar convertir el texto de las cajas a números (double).
            // Usamos TryParse para evitar errores si el usuario escribe letras.
            // Asumo que tus cajas de texto se llaman TextBox1 y TextBox2
            bool esNum1Valido = double.TryParse(TextBox1.Text, out num1);
            bool esNum2Valido = double.TryParse(TextBox2.Text, out num2);

            // 3. Comprobar si AMBOS son números válidos
            if (esNum1Valido && esNum2Valido)
            {
                // 4. Si son válidos, realizar la suma
                double resultado = num1 + num2;

                // 5. Mostrar el resultado en un Label.
                // ASUMO que tu Label de resultado se llama "LabelResultado"
                LabelResultado.Text = "El resultado es: " + resultado.ToString();
            }
            else
            {
                // 5b. Si uno o ambos no son números, mostrar un error
                LabelResultado.Text = "Error: Por favor, introduce solo números.";
            }
        }
    }
}