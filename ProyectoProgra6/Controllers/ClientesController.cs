using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoProgra6.Models;

namespace ProyectoProgra6.Controllers
{
    public class ClientesController : Controller
    {
        progra6bdEntities modeloBD = new progra6bdEntities();
        // GET: Clientes
        /// <summary>
        /// Metodo que se invoca al ingresar la direccion el navegador
        /// </summary>
        /// <returns></returns>
        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult ClientesLista()
        {
            ///crear la variable que contiene los registros obtenidos
            ///al invocar al procedimiento almacenado
            List<sp_RetornaCliente_Result> modeloVista =
                new List<sp_RetornaCliente_Result>();
            ///asignar a la variable el resultado de "llamar al procedimiento
            ///almacenado"
            modeloVista = this.modeloBD.sp_RetornaCliente("", "", "").ToList();
            //enviar a la vista el modelo
            return View(modeloVista);
        }

        public ActionResult ClienteNuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClienteNuevo(sp_RetornaCliente_Result modeloVista)
        {
            int cantRegistrosAfectados = 0;
            string resultado = "";

            try
            {
                cantRegistrosAfectados =
                    this.modeloBD.sp_InsertCliente(
                        modeloVista.Nombre,                                            
                        modeloVista.Cedula,                        
                        modeloVista.id_Provincia,
                        modeloVista.Id_Canton,
                        modeloVista.Id_Distrito,
                        modeloVista.Direccion_Fisica,
                        modeloVista.Telefono,
                        modeloVista.Correo_Electronico,
                        modeloVista.PrimerApellido,
                        modeloVista.SegundoApellido
                        );
            }
            catch (Exception error)
            {
                resultado = "Ocurrio un error" + error.Message;
            }
            finally
            {
                if (cantRegistrosAfectados > 0)
                {
                    resultado = "El registro fue insertado";
                }
                else
                {
                    resultado += "No se pudo insertar";
                }
            }

            Response.Write("<script language=javascript>alert('" + resultado + "');</script>");
            return View();
        }
    }
}