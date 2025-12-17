using SemestralDIV.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace SemestralDIV.Controllers
{
    public class InventarioController : Controller
    {
        string cadena = ConfigurationManager.ConnectionStrings["CadenaSQL"].ConnectionString;

        public ActionResult Dashboard()
        {
            DashboardViewModel modelo = new DashboardViewModel();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerEstadisticas", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            modelo.Etiquetas.Add(dr["Estado"].ToString());
                            modelo.Valores.Add(Convert.ToInt32(dr["Cantidad"]));
                        }
                    }
                }
            }
            catch { }
            return View(modelo);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Articulo articulo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarArticulo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NumeroPlaca", articulo.NumeroPlaca);
                    cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                    cmd.Parameters.AddWithValue("@Ubicacion", articulo.UbicacionPlano);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Dashboard");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ReporteMensual()
        {
            ReporteMensualViewModel modelo = new ReporteMensualViewModel();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteMensual", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            modelo.Meses.Add(dr["Mes"].ToString());
                            modelo.Cantidades.Add(Convert.ToInt32(dr["Cantidad"]));
                        }
                    }
                }
            }
            catch { }
            return View(modelo);
        }

        public ActionResult Gestionar()
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarArticulos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Articulo
                            {
                                IdArticulo = Convert.ToInt32(dr["IdArticulo"]),
                                NumeroPlaca = dr["NumeroPlaca"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Estado = dr["Estado"].ToString(),
                                UbicacionPlano = dr["UbicacionPlano"].ToString(),
                                FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"])
                            });
                        }
                    }
                }
            }
            catch { }
            return View(lista);
        }


        public ActionResult Editar(int id)
        {
            Articulo articulo = new Articulo();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerArticuloPorId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdArticulo", id);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            articulo.IdArticulo = Convert.ToInt32(dr["IdArticulo"]);
                            articulo.NumeroPlaca = dr["NumeroPlaca"].ToString();
                            articulo.Nombre = dr["Nombre"].ToString();
                            articulo.Descripcion = dr["Descripcion"].ToString();
                            articulo.Estado = dr["Estado"].ToString();
                            articulo.UbicacionPlano = dr["UbicacionPlano"].ToString();
                        }
                    }
                }
            }
            catch { }
            return View(articulo);
        }

        [HttpPost]
        public ActionResult Editar(Articulo articulo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActualizarEstado", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                    cmd.Parameters.AddWithValue("@Estado", articulo.Estado);
                    cmd.Parameters.AddWithValue("@Ubicacion", articulo.UbicacionPlano);
                    cmd.Parameters.AddWithValue("@Descripcion", articulo.Descripcion ?? ""); // Evita error si es nulo

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Gestionar");
            }
            catch
            {
                return View(articulo);
            }
        }
    }
}