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
        progra6bdEntities1 modeloBD = new progra6bdEntities1();
        // GET: Clientes
        /// <summary>
        /// Metodo que se invoca al ingresar la direccion el navegador
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
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
    }
}