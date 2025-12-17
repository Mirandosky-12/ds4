using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemestralDIV.Models
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string NumeroPlaca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string UbicacionPlano { get; set; }
        public DateTime FechaIngreso { get; set; } 
    }

    
    public class ReporteMensualViewModel
    {
        public List<string> Meses { get; set; } = new List<string>();
        public List<int> Cantidades { get; set; } = new List<int>();
    }

  
    public class DashboardViewModel
    {
        public List<string> Etiquetas { get; set; } = new List<string>();
        public List<int> Valores { get; set; } = new List<int>();
    }
}