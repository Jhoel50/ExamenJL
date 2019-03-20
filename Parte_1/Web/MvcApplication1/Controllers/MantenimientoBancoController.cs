using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class MantenimientoBancoController : Controller
    {
        //
        // GET: /MantenimientoBanco/

        public ActionResult ListarBancos()
        {

           List<BancoBE> ListadoTodos = new List<BancoBE>();

            BancoBE oBancoBE_1 = new BancoBE
            {
                ID = 100,
                Nombre = "BCP",
                Direccion = "Los alamos",
                fechaRegistro = DateTime.Now,
                oSucursalesBE = new SucursalesBE
                {
                    ID = 1,
                    Direccion = "DIREC_01",
                    Nombre = "SUCURSAL 1",
                    FechaRegistro = DateTime.Now,
                    oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 201, Estado = "2", Moneda = "1", monto = 100 }
                }
            };

            BancoBE oBancoBE_2 = new BancoBE { ID = 102, Nombre = "CONTINENTAL", Direccion = "Bolognesii", fechaRegistro = DateTime.Now, oSucursalesBE = new SucursalesBE { ID = 2, Direccion = "DIREC 01", Nombre = "SUCURSAL 2", FechaRegistro = DateTime.Now, oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 202, Estado = "1", Moneda = "1", monto = 200 } } };

            BancoBE oBancoBE_3 = new BancoBE { ID = 103, Nombre = "Scotiabanck", Direccion = "Grau N:234", fechaRegistro = DateTime.Now, oSucursalesBE = new SucursalesBE { ID = 3, Direccion = "DIREC 02", Nombre = "SUCURSAL 3", FechaRegistro = DateTime.Now, oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 203, Estado = "4", Moneda = "2", monto = 300 } } };


            BancoBE oBancoBE_4 = new BancoBE { ID = 104, Nombre = "Ripley", Direccion = "Rio Pampamarca", fechaRegistro = DateTime.Now, oSucursalesBE = new SucursalesBE { ID = 4, Direccion = "DIREC 03", Nombre = "SUCURSAL 4", FechaRegistro = DateTime.Now, oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 204, Estado = "3", Moneda = "1", monto = 400 } } };

            ListadoTodos.Add(oBancoBE_1);
            ListadoTodos.Add(oBancoBE_2);
            ListadoTodos.Add(oBancoBE_3);
            ListadoTodos.Add(oBancoBE_4);


            List<SucursalesBE> ListaTodosSucursales = new List<SucursalesBE>();

            SucursalesBE oSucursalesBE_1 = new SucursalesBE
            {
                ID = 1,
                Direccion = "DIREC 01",
                FechaRegistro = DateTime.Now,
                Nombre = "SUCURSAL 1",
                oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 101, Estado = "PAGADA", Moneda = "SOLES", monto = 100 }
            };

            SucursalesBE oSucursalesBE_2 = new SucursalesBE
            {
                ID = 2,
                Direccion = "DIREC 02",
                FechaRegistro = DateTime.Now,
                Nombre = "SUCURSAL 2",
                oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 103, Estado = "PAGADA", Moneda = "SOLES", monto = 500 }
            };

            SucursalesBE oSucursalesBE_3 = new SucursalesBE
            {
                ID = 3,
                Direccion = "DIREC 03",
                FechaRegistro = DateTime.Now,
                Nombre = "SUCURSAL 3",
                oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 104, Estado = "FALLIDA", Moneda = "SOLES", monto = 800 }
            };

            SucursalesBE oSucursalesBE_4 = new SucursalesBE
            {
                ID = 4,
                Direccion = "DIREC 04",
                FechaRegistro = DateTime.Now,
                Nombre = "SUCURSAL 4",
                oOrdenesDePagoBE = new OrdenesDePagoBE { ID = 105, Estado = "FALLIDA", Moneda = "DOLARES", monto = 5000 }
            };

            ListaTodosSucursales.Add(oSucursalesBE_1);
            ListaTodosSucursales.Add(oSucursalesBE_2);
            ListaTodosSucursales.Add(oSucursalesBE_3);
            ListaTodosSucursales.Add(oSucursalesBE_4);

          


            Session["ListaBanco"] = ListadoTodos;
            Session["ListaSucursal"] = ListaTodosSucursales;

            ViewBag.dllSucursal = listaSucursal(ListaTodosSucursales,"*");
            
            return View();
        }

        private List<SelectListItem> listaSucursal(List<SucursalesBE> oSucursalesBE,string value)
        {
            try
            {
                List<SelectListItem> lstSucursal = new List<SelectListItem>();

                foreach (var item in oSucursalesBE)
                {
                    if (item.ID.ToString() == value)
                    {
                        lstSucursal.Add(new SelectListItem() { Text = item.Nombre, Value = item.ID.ToString(), Selected = true });
                    }
                    else
                    {
                        lstSucursal.Add(new SelectListItem() { Text = item.Nombre, Value = item.ID.ToString(), Selected = false });
                    }
                    
                }
                return lstSucursal.OrderBy(o => o.Text).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<SelectListItem> listaEstados(string value)
        {
            try
            {
                List<SelectListItem> lstEstado = new List<SelectListItem>();
                lstEstado.Add(new SelectListItem() { Text = "Pagada", Value = "1" });
                lstEstado.Add(new SelectListItem() { Text = "Declinada", Value = "2" });
                lstEstado.Add(new SelectListItem() { Text = "Fallida", Value = "3" });
                lstEstado.Add(new SelectListItem() { Text = "Anulada", Value = "4" });
                if (value != "*")
                {
                    SelectListItem item = lstEstado.Where(e => e.Value == value).FirstOrDefault();
                    item.Selected = true;
                }
                return lstEstado.OrderBy(o => o.Text).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<SelectListItem> Moneda(string value)
        {
            try
            {
                List<SelectListItem> lstEstado = new List<SelectListItem>();
                lstEstado.Add(new SelectListItem() { Text = "SOLES", Value = "1" });
                lstEstado.Add(new SelectListItem() { Text = "DOLARES", Value = "2" });
                lstEstado.Add(new SelectListItem() { Text = "EURO", Value = "3" });
                if (value != "*")
                {
                    SelectListItem item = lstEstado.Where(e => e.Value == value).FirstOrDefault();
                    item.Selected = true;
                }
                return lstEstado.OrderBy(o => o.Text).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet]
        public ActionResult ListarBancoGrid(string ID)
        {
            ViewBag.ddlMoneda = Moneda("*");
            var ListadoTodos= Session["ListaBanco"];
            return PartialView("_ListarBancoGrid", ListadoTodos);
        }
        [HttpGet]
        public ActionResult Edit(Int32 ID)
        {



            BancoBE IEBanco= new BancoBE();
            if (ID != 0)
            { 
                List<BancoBE> ListaBanco = new List<BancoBE>();
                ListaBanco = (List<BancoBE>)Session["ListaBanco"];
                IEBanco = ListaBanco.Find(a => a.ID.ToString() == ID.ToString());
                ViewBag.dllSucursal = listaSucursal((List<SucursalesBE>)Session["ListaSucursal"], IEBanco.oSucursalesBE.ID.ToString());
                ViewBag.ddlEstado = listaEstados(IEBanco.oSucursalesBE.oOrdenesDePagoBE.Estado);
                ViewBag.ddlMoneda = Moneda(IEBanco.oSucursalesBE.oOrdenesDePagoBE.Moneda);
            }
            else
            {
                if(Session["ListaBanco"]!=null)
                {
                    List<BancoBE> ListaBanco = new List<BancoBE>();
                    ListaBanco = (List<BancoBE>)Session["ListaBanco"];
                    IEBanco.ID = ListaBanco.Max(e => e.ID)+1;
                    
                }
                else
                {
                    IEBanco.ID = 1;
                }
                ViewBag.dllSucursal = listaSucursal((List<SucursalesBE>)Session["ListaSucursal"], "*");
                ViewBag.ddlEstado = listaEstados("*");
                ViewBag.ddlMoneda = Moneda("*");
            }

     

            return PartialView("_EditBanco", IEBanco);
        }

        [HttpPost]
        public JsonResult Guardar(Int32 ID, string Banco, string direccion, string IDSucursal, string monto,string moneda,string estado)
        {
            BancoBE IEBanco= new BancoBE();
            List<BancoBE> ListaBanco = new List<BancoBE>();
            SucursalesBE IESucursalesBE;
            OrdenesDePagoBE IEOrdenesDePagoBE= new OrdenesDePagoBE();

            ListaBanco = (List<BancoBE>)Session["ListaBanco"];

            var ExisteEntity = ListaBanco.Find(a => a.ID.ToString() == ID.ToString());
            
            if (ExisteEntity == null)
            {
                IEBanco.ID = ListaBanco.Max(e => e.ID) + 1;
                IEBanco.Nombre = Banco;
                IEBanco.Direccion = direccion;

            }
            else
            {
                IEBanco = ListaBanco.Find(a => a.ID.ToString() == ID.ToString());
                IEBanco.Direccion = direccion;
                IEBanco.Nombre = Banco;
            }

            var ListaTodosSucursales = (List<SucursalesBE>)Session["ListaSucursal"];
             IESucursalesBE = ListaTodosSucursales.Find(a => a.ID.ToString() == IDSucursal);
            IEBanco.oSucursalesBE = IESucursalesBE;

            IEOrdenesDePagoBE.ID = IEBanco.oSucursalesBE.oOrdenesDePagoBE.ID + 1;
            IEOrdenesDePagoBE.monto = Convert.ToDecimal(monto);
            IEOrdenesDePagoBE.Moneda = moneda;
            IEOrdenesDePagoBE.Estado = estado;
            IEBanco.oSucursalesBE.oOrdenesDePagoBE = IEOrdenesDePagoBE;

            if (ExisteEntity == null)
            {
                ListaBanco.Add(IEBanco);
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
            BancoBE IEBanco;
            List<BancoBE> ListaBanco = new List<BancoBE>();
            ListaBanco = (List<BancoBE>)Session["ListaBanco"];
            IEBanco = ListaBanco.Find(a => a.ID.ToString() == ID.ToString());
            ListaBanco.Remove(IEBanco);
            return Json(new
            {
                success = true,
                message = "OK",
                extra = ""
            });
        }


    }
}
