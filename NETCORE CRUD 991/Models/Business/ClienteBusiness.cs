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

    public class ClienteBusiness : IClienteBusiness
    {
        private readonly DbContextPrueba _context;

        public ClienteBusiness(DbContextPrueba context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> ObtenerClienteTodos()
        {
            return (await _context.cliente.ToListAsync());
        }
        public async Task<IEnumerable<Cliente>> ObtenerClientePorNombrePorCasillero(string busqueda)
        {
            await using (_context)
            {
                IEnumerable<Cliente> listaclientes =
                    (from cliente in _context.cliente
                     where (cliente.Nombre.Contains(busqueda) || cliente.IdCliente.ToString().Equals(busqueda))
                     select new Cliente
                     {
                         IdCliente = cliente.IdCliente,
                         Nombre = cliente.Nombre,
                         Correo = cliente.Correo,
                         Direccion = cliente.Direccion
                     }).ToList();

                return (listaclientes);
            }
        }
        public async Task<Cliente> ObtenerClientePorCasillero(int? id)
        {
            Cliente cliente = null;

            if (id == null) return cliente;
            else
            {
                cliente = await _context.cliente.FirstOrDefaultAsync(e => e.IdCliente == id);
                return cliente;
            }
        }
        public async Task GuardarEditarCliente(Cliente cliente)
        {
            try
            {
                if (cliente.IdCliente == 0) _context.Add(cliente);
                else _context.Update(cliente);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task EliminarCliente(Cliente cliente)
        {
            try
            {
                _context.cliente.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
