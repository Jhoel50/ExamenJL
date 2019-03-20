using Coworking.Api.DataAccess.Contracts.Entities;
using System;

namespace Coworking.Api.DataAccess.Repositories
{
    public class UnitOfWork
    {
        private static UnitOfWork _unitOfWork;
        private BancoEntity _banco;
        private SucursalEntity _sucursal;
        private OrdenPagoEntity _ordenPago;

        public UnitOfWork()
        {
            BancoRepository = new BancoRepository();
            SucursalRepository = new SucursalRepository();
            OrdenPagoRepository = new OrdenPagoRepository();
            LoadBancos();
            LoadSucursales();
            LoadOrdenesPago();
        }

        public static UnitOfWork GetInstance
        {
            get
            {
                if (_unitOfWork == null)
                {
                    _unitOfWork = new UnitOfWork();
                }
                return _unitOfWork;
            }
        }
        private void LoadBancos()
        {
            _banco = new BancoEntity();
            _banco.Id = 1;
            _banco.Nombre = "BCP";
            _banco.Direccion = "Direccion principal";
            _banco.FechaRegistro = DateTime.Now;
            BancoRepository.Bancos.Add(_banco);

            _banco = new BancoEntity();
            _banco.Id = 2;
            _banco.Nombre = "Interbank";
            _banco.Direccion = "Direccion Principal";
            _banco.FechaRegistro = DateTime.Now;
            BancoRepository.Bancos.Add(_banco);

            _banco = new BancoEntity();
            _banco.Id = 3;
            _banco.Nombre = "Scotiaback";
            _banco.Direccion = "Direccion Principal";
            _banco.FechaRegistro = DateTime.Now;
            BancoRepository.Bancos.Add(_banco);
        }
        private void LoadSucursales()
        {
            _sucursal = new SucursalEntity();
            _sucursal.Id = 1;
            _sucursal.Nombre = "Sucursal Bcp 01";
            _sucursal.Direccion = "San Isidro";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[0];
            SucursalRepository.Sucursal.Add(_sucursal);

            _sucursal = new SucursalEntity();
            _sucursal.Id = 2;
            _sucursal.Nombre = "Sucursal Bcp 02";
            _sucursal.Direccion = "Chorrillos";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[0];
            SucursalRepository.Sucursal.Add(_sucursal);

            _sucursal = new SucursalEntity();
            _sucursal.Id = 3;
            _sucursal.Nombre = "Sucursal Interbank 01";
            _sucursal.Direccion = "San Isidro";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursal.Add(_sucursal);

            _sucursal = new SucursalEntity();
            _sucursal.Id = 4;
            _sucursal.Nombre = "Sucursal Interbank 02";
            _sucursal.Direccion = "Chorrillos";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursal.Add(_sucursal);

            _sucursal = new SucursalEntity();
            _sucursal.Id = 5;
            _sucursal.Nombre = "Sucursal Interbank 03";
            _sucursal.Direccion = "San Juan de Lurigancho";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursal.Add(_sucursal);
        }
        private void LoadOrdenesPago()
        {
            _ordenPago = new OrdenPagoEntity();
            _ordenPago.Id = 1;
            _ordenPago.Monto = 200;
            _ordenPago.Moneda = "Soles";
            _ordenPago.Estado = "Pagada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursal[0];
            OrdenPagoRepository.OrdenPago.Add(_ordenPago);

            _ordenPago = new OrdenPagoEntity();
            _ordenPago.Id = 2;
            _ordenPago.Monto = 745;
            _ordenPago.Moneda = "Dolares";
            _ordenPago.Estado = "Declinada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursal[1];
            OrdenPagoRepository.OrdenPago.Add(_ordenPago);

            _ordenPago = new OrdenPagoEntity();
            _ordenPago.Id = 3;
            _ordenPago.Monto = 4000;
            _ordenPago.Moneda = "Soles";
            _ordenPago.Estado = "Fallida";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursal[2];
            OrdenPagoRepository.OrdenPago.Add(_ordenPago);

            _ordenPago = new OrdenPagoEntity();
            _ordenPago.Id = 4;
            _ordenPago.Monto = 14000;
            _ordenPago.Moneda = "Dolares";
            _ordenPago.Estado = "Anulada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursal[2];
            OrdenPagoRepository.OrdenPago.Add(_ordenPago);
        }

        public BancoRepository BancoRepository { get; set; }
        public SucursalRepository SucursalRepository { get; set; }
        public OrdenPagoRepository OrdenPagoRepository { get; set; }
    }
}