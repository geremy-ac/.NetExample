using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Abstract
{
    public interface ITransportadorasBusiness
    {
        Task<IEnumerable<Transportadoras>> ObtenerTransportadorasTodos();
        Task<IEnumerable<Transportadoras>> ObtenerTransportadoraPorNombrePorId(string busqueda);
        Task<Transportadoras> ObtenerTransportadoraPorID(int? id);
        Task GuardarEditarTransportadora(Transportadoras transportadoras);
        Task EliminarTransportadora(Transportadoras transportadoras);

    }
}
