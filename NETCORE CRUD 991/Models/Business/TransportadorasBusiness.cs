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

    public class TransportadorasBusiness : ITransportadorasBusiness
    {
        private readonly DbContextPrueba _context;

        public TransportadorasBusiness(DbContextPrueba context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transportadoras>> ObtenerTransportadorasTodos()
        {
            return (await _context.transportadoras.ToListAsync());
        }
        public async Task<IEnumerable<Transportadoras>> ObtenerTransportadoraPorNombrePorId(string busqueda)
        {
            await using (_context)
            {
                IEnumerable<Transportadoras> listatransportadoras =
                    (from transportadoras in _context.transportadoras
                     where (transportadoras.Nombre.Contains(busqueda) || transportadoras.IdTransportadora.ToString().Equals(busqueda))
                     select new Transportadoras
                     {
                         IdTransportadora = transportadoras.IdTransportadora,
                         Nombre = transportadoras.Nombre,
                     }).ToList();

                return (listatransportadoras);
            }
        }
        public async Task<Transportadoras> ObtenerTransportadoraPorID(int? id)
        {
            Transportadoras transportadoras = null;

            if (id == null) return transportadoras;
            else
            {
                transportadoras = await _context.transportadoras.FirstOrDefaultAsync(e => e.IdTransportadora == id);
                return transportadoras;
            }
        }
        public async Task GuardarEditarTransportadora(Transportadoras transportadoras)
        {
            try
            {
                if (transportadoras.IdTransportadora == 0) _context.Add(transportadoras);
                else _context.Update(transportadoras);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task EliminarTransportadora(Transportadoras transportadoras)
        {
            try
            {
                _context.transportadoras.Remove(transportadoras);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
