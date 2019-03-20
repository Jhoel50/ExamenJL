using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class SucursalesController : Controller
    {
        //
        // GET: /Sucursales/

        public ActionResult ListaSucursales()
        {
            
            List<SucursalesBE> ListadoTodos = new List<SucursalesBE>();

            SucursalesBE oSucursalesBE_1 = new SucursalesBE
            {
                 Direccion="Direccion 01",
                  FechaRegistro=DateTime.Now,
                   ID=1001,
                  Nombre="LA MOLINA"
            };


            SucursalesBE oSucursalesBE_2 = new SucursalesBE
            {
                Direccion = "Direccion 02",
                FechaRegistro = DateTime.Now,
                ID = 1002,
                Nombre = "SAN ISIDRO"
            };

            SucursalesBE oSucursalesBE_3 = new SucursalesBE
            {
                Direccion = "Direccion 03",
                FechaRegistro = DateTime.Now,
                ID = 1003,
                Nombre = "San Juan Lurigancho"
           
            };

            SucursalesBE oSucursalesBE_4 = new SucursalesBE
            {
                Direccion = "Direccion 04",
                FechaRegistro = DateTime.Now,
                ID = 1001,
                Nombre = "Chorrillos"
            };

            SucursalesBE oSucursalesBE_5 = new SucursalesBE
            {
                Direccion = "Direccion 05",
                FechaRegistro = DateTime.Now,
                ID = 1001,
                Nombre = "Santa Anita"
            };
            ListadoTodos.Add(oSucursalesBE_1);
            ListadoTodos.Add(oSucursalesBE_2);
            ListadoTodos.Add(oSucursalesBE_3);
            ListadoTodos.Add(oSucursalesBE_4);
            ListadoTodos.Add(oSucursalesBE_5);

            Session["ListaSucursal"] = ListadoTodos;
            return View();
        }

        [HttpGet]
        public ActionResult ListarSucursalGrid(string ID)
        {
            var ListadoTodos = Session["ListaSucursal"];
            return PartialView("ListarSucursalGrid", ListadoTodos);
        }
        [HttpGet]
        public ActionResult Edit(Int32 ID)
        {
            SucursalesBE IESucursalesBE = new SucursalesBE();
            if (ID != 0)
            {
                List<SucursalesBE> ListaSucursal = new List<SucursalesBE>();
                ListaSucursal = (List<SucursalesBE>)Session["ListaSucursal"];
                IESucursalesBE = ListaSucursal.Find(a => a.ID.ToString() == ID.ToString());
            }
            else
            {
                IESucursalesBE.ID = 1;
            }

            return PartialView("_EditSucursal", IESucursalesBE);
        }

        [HttpPost]
        public JsonResult Guardar(Int32 ID, string Sucursal, string direccion)
        {

            SucursalesBE IESucursalesBE= new SucursalesBE();

            List<SucursalesBE> ListaSucursal = new List<SucursalesBE>();
            ListaSucursal = (List<SucursalesBE>)Session["ListaSucursal"];


            var ExisteEntity = ListaSucursal.Find(a => a.ID.ToString() == ID.ToString());

            if (ExisteEntity == null)
            {
                IESucursalesBE.ID = ListaSucursal.Max(e => e.ID) + 1;
                IESucursalesBE.Direccion = direccion;
                IESucursalesBE.Nombre = Sucursal;
            }
            else
            {
                IESucursalesBE = ListaSucursal.Find(a => a.ID.ToString() == ID.ToString());
                IESucursalesBE.Direccion = direccion;
                IESucursalesBE.Nombre = Sucursal;
            }

            if (ExisteEntity == null)
            {
                ListaSucursal.Add(IESucursalesBE);
            }
            return Json(new
            {
                success = true,
                message = "OK",
                extra = ""
            });
        }

        [HttpPost]
        public JsonResult Eliminar(Int32 ID)
        {
            SucursalesBE IESucursal;
            List<SucursalesBE> ListaSucursal = new List<SucursalesBE>();
            ListaSucursal = (List<SucursalesBE>)Session["ListaSucursal"];
            IESucursal = ListaSucursal.Find(a => a.ID.ToString() == ID.ToString());
            ListaSucursal.Remove(IESucursal);
            return Json(new
            {
                success = true,
                message = "OK",
                extra = ""
            });
        }

    }
}
