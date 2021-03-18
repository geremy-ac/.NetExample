using NETCORE_CRUD_991.Clases;
using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Abstract
{
    public interface IPaqueteBusiness
    {
        Task<IEnumerable<PaqueteDetalle>> ObtenerPaqueteTodos();
        Task<IEnumerable<ValorLibra>> ObtenerValorLibraTodos();
        Task<IEnumerable<PaqueteDetalle>> ObtenerPaquetePorCasilleroPorCodigo(string busqueda);
        Task<Paquete> ObtenerPaquetePorCodigo(int? id);
        Task GuardarEditarPaquete(Paquete paquete);
        Task EliminarPaquete(Paquete paquete);
        Task<IEnumerable<Cliente>> ObtenerClienteTodos();
        Task<IEnumerable<Transportadoras>> ObtenerTransportadoraTodos();
        Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaTodos();
        Task<PaqueteDetalle> ObtenerPaqueteDetalleTodos(int? id);
    }
}
