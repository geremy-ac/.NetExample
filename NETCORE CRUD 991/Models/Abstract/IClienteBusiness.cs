using NETCORE_CRUD_991.Clases;
using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.Abstract
{
    public interface IClienteBusiness
    {
        Task<IEnumerable<Cliente>> ObtenerClienteTodos();
        Task<IEnumerable<Cliente>> ObtenerClientePorNombrePorCasillero(string busqueda);
        Task<Cliente> ObtenerClientePorCasillero(int? id);
        Task GuardarEditarCliente(Cliente cliente);
       Task EliminarCliente(Cliente cliente);
    }
}
