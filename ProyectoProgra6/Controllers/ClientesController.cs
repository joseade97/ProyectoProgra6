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
            AgregaProvinciasViewBag();
            AgregaCantonesViewBag();
            AgregaDistritosViewBag();
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
            AgregaProvinciasViewBag();
            AgregaCantonesViewBag();
            AgregaDistritosViewBag();
            return View();
        }

        public ActionResult ClienteModifica(int Id_Cliente)
        {
            ///obtener el registro que se desea modificar
            ///utilizando el parametro del metodo Id_Cliente
            sp_RetornaCliente_ID_Result modeloVista = new sp_RetornaCliente_ID_Result();
            modeloVista = this.modeloBD.sp_RetornaCliente_ID(Id_Cliente).FirstOrDefault();
            this.AgregaProvinciasViewBag();
            this.AgregaCantonesViewBag();
            this.AgregaDistritosViewBag();
            ///enviar el modelo a la vista
            return View(modeloVista);
        }

        [HttpPost]
        public ActionResult ClienteModifica(sp_RetornaCliente_ID_Result modeloVista)
        {
            /*Variable que registra la cantidad de registros afectados
             * si un procedimiento que ejectua insert, update o delete
             * no afecta registros implica que hubo un error
             */
            int cantRegistrosAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistrosAfectados = this.modeloBD.sp_UpdateCliente(
                    modeloVista.Id_Cliente,
                    modeloVista.Nombre,
                    modeloVista.Cedula,
                    modeloVista.id_Provincia,
                    modeloVista.id_Canton,
                    modeloVista.id_Distrito,
                    modeloVista.Direccion_Fisica,
                    modeloVista.Telefono,
                    modeloVista.Correo_Electronico,
                    modeloVista.primerApellido,
                    modeloVista.segundoApellido
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
                    resultado = "El registro fue modificado";
                }
                else
                {
                    resultado += "No se pudo modificar";
                }
            }
            Response.Write("<script language=javascript>alert('" + resultado + "');</script>");
            this.AgregaProvinciasViewBag();
            this.AgregaCantonesViewBag();
            this.AgregaDistritosViewBag();
            return View(modeloVista);
        }

        public ActionResult ClienteElimina(int id_Cliente)
        {
            sp_RetornaCliente_ID_Result modeloVista = new sp_RetornaCliente_ID_Result();
            modeloVista = this.modeloBD.sp_RetornaCliente_ID(id_Cliente).FirstOrDefault();
            this.AgregaProvinciasViewBag();
            this.AgregaCantonesViewBag();
            this.AgregaDistritosViewBag();
            return View(modeloVista);
        }

        [HttpPost]
        public ActionResult ClienteElimina(sp_RetornaCliente_ID_Result modeloVista)
        {
            /*Variable que registra la cantidad de registros afectados
             * si un procedimiento que ejectua insert, update o delete
             * no afecta registros implica que hubo un error
             */
            int cantRegistrosAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistrosAfectados =
                    this.modeloBD.sp_EliminaCliente(modeloVista.Id_Cliente);
            }
            catch (Exception error)
            {

                resultado = "Ocurrio un error: " + error.Message;
            }
            finally
            {
                if (cantRegistrosAfectados > 0)
                {
                    resultado = "El registro fue eliminado";
                }
                else
                {
                    resultado += "No se pudo modificar";
                }
            }
            Response.Write("<script language=javascript>alert('" + resultado + "');</script>");
            this.AgregaProvinciasViewBag();
            this.AgregaCantonesViewBag();
            this.AgregaDistritosViewBag();
            return View(modeloVista);
        }

        void AgregaProvinciasViewBag()
        {
            this.ViewBag.ListaProvincias =
                this.modeloBD.sp_RetornaProvincias("").ToList();
        }

        void AgregaCantonesViewBag()
        {
            this.ViewBag.ListaCantones =
                this.modeloBD.sp_RetornaCantones("",null).ToList();
        }
        void AgregaDistritosViewBag()
        {
            this.ViewBag.ListaDistritos =
                this.modeloBD.sp_RetornaDistritos("", null).ToList();
        }
    }
}