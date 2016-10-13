using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AzureSGADBComasur.Models;
using System.Web.Mvc;
using AzureSGADBComasur.FiltrosPersonalizados;

namespace AzureSGADBComasur.Controllers
{
    public class PermisosController : Controller

    {
        ModeloPermisoEntities1 ctx;

        public PermisosController()
        {
            ctx = new ModeloPermisoEntities1();
        }

        // GET: Product
        public ActionResult Index()
        {
            var Permisos = ctx.PermisosTable.ToList();
            return View(Permisos);
        }

        [AuthLog(Roles = "Administrador Global")]
        public ActionResult Create()
        {
            var Permiso = new PermisosTable();
            return View(Permiso);
        }




        [HttpPost]
        public ActionResult Create(PermisosTable t)
        {
            ctx.PermisosTable.Add(t);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        [AuthLog(Roles = "Capturista")]
        public ActionResult SalePermiso()
        {
            ViewBag.Message = "Esta vista está diseñado para el ejecutivo de ventas para la venta del producto";
            return View();
        }

    }
}
