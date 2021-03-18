using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NETCORE_CRUD_991.Clases;
using NETCORE_CRUD_991.Models.Abstract;
using NETCORE_CRUD_991.Models.DAL;
using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Business
{

    public class PaqueteBusiness:IPaqueteBusiness
    {
        private readonly DbContextPrueba _context;

        public PaqueteBusiness(DbContextPrueba context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaqueteDetalle>> ObtenerPaqueteTodos()
        {
            await using (_context)
            {
                IEnumerable<PaqueteDetalle> listapaqueteDetalles =
                    (from paquetes in _context.paquetes
                     join clientes in _context.cliente
                     on paquetes.IdCliente equals clientes.IdCliente
                     join transportadoras in _context.transportadoras
                     on paquetes.IdTransportadora equals transportadoras.IdTransportadora
                     join tipomercancias in _context.tipomercancias
                     on paquetes.IdTipoMercancia equals tipomercancias.IdTipoMercancia
                     join valorlibra in _context.valorlibra
                     on paquetes.IdValorLibra equals valorlibra.IdValorLibra
                     select new PaqueteDetalle
                     {
                         IdPaquete = paquetes.IdPaquete,
                         CodigoPaquete = paquetes.CodigoPaquete,
                         PesoLibra = paquetes.PesoLibra,
                         Casillero = paquetes.IdCliente.ToString(),
                         NombreCasillero = clientes.Nombre,
                         Estado = paquetes.Estado,
                         USA = paquetes.USA,
                         Transportadora = transportadoras.Nombre,
                         TipoMercancia = tipomercancias.Nombre,
                         COL = paquetes.COL,
                         ValorLibra = valorlibra.Valor,
                         ValorPagar = paquetes.ValorPagar
                     }).ToList();
                return (listapaqueteDetalles);
            }
        }
        public async Task <PaqueteDetalle> ObtenerPaqueteDetalleTodos(int? id)
        {
            await using (_context)
            {
                IEnumerable<PaqueteDetalle> PaqueList =
                    (from paquetes in _context.paquetes
                     join clientes in _context.cliente
                     on paquetes.IdCliente equals clientes.IdCliente
                     join transportadoras in _context.transportadoras
                     on paquetes.IdTransportadora equals transportadoras.IdTransportadora
                     join tipomercancias in _context.tipomercancias
                     on paquetes.IdTipoMercancia equals tipomercancias.IdTipoMercancia
                     join valorlibra in _context.valorlibra
                     on paquetes.IdValorLibra equals valorlibra.IdValorLibra
                     where (paquetes.IdPaquete == id)
                     select new PaqueteDetalle
                     {
                         IdPaquete = paquetes.IdPaquete,
                         CodigoPaquete = paquetes.CodigoPaquete,
                         PesoLibra = paquetes.PesoLibra,
                         Casillero = paquetes.IdCliente.ToString(),
                         NombreCasillero = clientes.Nombre,
                         Estado = paquetes.Estado,
                         USA = paquetes.USA,
                         Transportadora = transportadoras.Nombre,
                         TipoMercancia = tipomercancias.Nombre,
                         COL = paquetes.COL,
                         ValorLibra = valorlibra.Valor,
                         ValorPagar = paquetes.ValorPagar
                     }).ToList();
                PaqueteDetalle Paque = PaqueList.FirstOrDefault();
                return Paque;
            }
        }

        public async Task<IEnumerable<PaqueteDetalle>> ObtenerPaquetePorCasilleroPorCodigo(string busqueda)
        {
            await using (_context)
            {
                IEnumerable<PaqueteDetalle> listapaqueteDetalles =
                    (from paquetes in _context.paquetes
                     join clientes in _context.cliente
                     on paquetes.IdCliente equals clientes.IdCliente
                     join transportadoras in _context.transportadoras
                     on paquetes.IdTransportadora equals transportadoras.IdTransportadora
                     join tipomercancias in _context.tipomercancias
                     on paquetes.IdTipoMercancia equals tipomercancias.IdTipoMercancia
                     join valorlibra in _context.valorlibra
                     on paquetes.IdValorLibra equals valorlibra.IdValorLibra
                     where (paquetes.IdCliente.ToString().Equals(busqueda) || paquetes.CodigoPaquete.ToString().Equals(busqueda))
                     select new PaqueteDetalle
                     {
                         IdPaquete = paquetes.IdPaquete,
                         CodigoPaquete = paquetes.CodigoPaquete,
                         PesoLibra = paquetes.PesoLibra,
                         Casillero = paquetes.IdCliente.ToString(),
                         NombreCasillero = clientes.Nombre,
                         Estado = paquetes.Estado,
                         USA = paquetes.USA,
                         Transportadora = transportadoras.Nombre,
                         TipoMercancia = tipomercancias.Nombre,
                         COL = paquetes.COL,
                         ValorLibra = valorlibra.Valor,
                         ValorPagar = paquetes.ValorPagar
                     }).ToList();
                return (listapaqueteDetalles);
            }
        }
        public async Task<Paquete> ObtenerPaquetePorCodigo(int? id)
        {
            Paquete paquete = null;

            if (id == null) return paquete;
            else
            {
                paquete = await _context.paquetes.FirstOrDefaultAsync(e => e.IdPaquete == id);
                return paquete;
            }
        }
         public async Task GuardarEditarPaquete(Paquete paquete)
        {
            try
            {
                if (paquete.IdPaquete == 0)
                {
                    int mostrar;
                    using (SqlConnection cn = new SqlConnection("Data Source = DESKTOP-RR4UME5\\SQLEXPRESS; Initial Catalog = DcImportaciones; Integrated Security = true"))
                    {
                        int MaxId;
                        cn.Open();
                        string sql = "SELECT MAX(IdPaquete) FROM paquetes";
                        SqlCommand cmd = new SqlCommand(sql, cn);
                        int.TryParse(cmd.ExecuteScalar().ToString(), out MaxId);
                        mostrar = MaxId + 1;
                    }
                    ValorLibra mult = await _context.valorlibra.FirstOrDefaultAsync(e => e.IdValorLibra == paquete.IdValorLibra);
                    paquete.ValorPagar = paquete.PesoLibra * mult.Valor;
                    var todos = _context.paquetes.ToList().Count();
                    var l = _context.paquetes.ToList().Count();
                    paquete.CodigoPaquete = ("MIA" + (mostrar).ToString());
                    _context.paquetes.Add(paquete);

                }
                else _context.Update(paquete);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception();
            }

        }

        public async Task EliminarPaquete(Paquete paquete)
        {
            try
            {
                _context.paquetes.Remove(paquete);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<IEnumerable<Cliente>> ObtenerClienteTodos()
        {
            return await _context.cliente.ToArrayAsync();
        }
        public async Task<IEnumerable<ValorLibra>> ObtenerValorLibraTodos()
        {
            return await _context.valorlibra.ToArrayAsync();
        }
        public async Task<IEnumerable<Transportadoras>> ObtenerTransportadoraTodos()
        {
            return await _context.transportadoras.ToArrayAsync();
        }
        public async Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaTodos()
        {
            return await _context.tipomercancias.ToArrayAsync();
        }
        public async Task<IEnumerable<Estado>> ObtenerEstadosTodos()
        {
            return await _context.estadoss.ToArrayAsync();
        }
    }
}
