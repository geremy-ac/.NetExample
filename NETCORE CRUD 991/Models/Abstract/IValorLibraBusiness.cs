using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Abstract
{
    public interface IValorLibraBusiness
    {
        Task<IEnumerable<ValorLibra>> ObtenerValorLibraTodos();
        Task<IEnumerable<ValorLibra>> ObtenerValorLibraPorNombrePorId(string busqueda);
        Task<ValorLibra> ObtenerValorLibraPorID(int? id);
        Task GuardarEditarValorLibra(ValorLibra valorLibra);

    }
}
