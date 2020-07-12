using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoProgra6.Models;

namespace ProyectoProgra6.Controllers
{
    public class GeografiaController : Controller
    {
        progra6bdEntities modeloBD = new progra6bdEntities();

        // GET: Geografia
        public ActionResult Geografia()
        {
            return View();
        }

        public ActionResult RetornaProvincias()
        {
            List<sp_RetornaProvincias_Result> provincias =
                this.modeloBD.sp_RetornaProvincias(null).ToList();
            return Json(provincias);
        }

        /// <summary>
        /// Retorna todas las provincias
        /// </summary>
        /// <param name="id_provincia">id de provincia</param>
        /// <returns></returns>
        public ActionResult RetornaCantones(int id_Provincia)
        {
            List<sp_RetornaCantones_Result> cantones =
                this.modeloBD.sp_RetornaCantones(null,id_Provincia).ToList();
            return Json(cantones);
        }

        /// <summary>
        /// Retorna todas las distritos
        /// </summary>
        /// <param name="idcanton">id de canton</param>
        /// <returns></returns>
        public ActionResult RetornaDistritos(int id_Canton)
        {
            List<sp_RetornaDistritos_Result> distritos =
                this.modeloBD.sp_RetornaDistritos(null,id_Canton).ToList();
            return Json(distritos);
        }
    }
}