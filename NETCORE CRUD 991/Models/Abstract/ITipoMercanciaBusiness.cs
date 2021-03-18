using NETCORE_CRUD_991.Clases;
using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Abstract
{
    public interface ITipoMercanciaBusiness
    {
        Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaTodos();
        Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaPorNombrePorId(string busqueda);
        Task<TipoMercancia> ObtenerTipoMercanciaPorID(int? id);
        Task GuardarEditarTipoMercancia(TipoMercancia tipomercancia);
        Task EliminarTipoMercancia(TipoMercancia tipomercancia);
    }
}
