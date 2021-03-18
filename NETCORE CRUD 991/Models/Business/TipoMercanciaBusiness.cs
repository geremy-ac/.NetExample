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

    public class TipoMercanciaBusiness : ITipoMercanciaBusiness
    {
        private readonly DbContextPrueba _context;

        public TipoMercanciaBusiness(DbContextPrueba context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaTodos()
        {
           return (await _context.tipomercancias.ToListAsync());
        }
        public async Task<IEnumerable<TipoMercancia>> ObtenerTipoMercanciaPorNombrePorId(string busqueda)
        {
            await using (_context)
            {
                IEnumerable<TipoMercancia> listatipomercancia =
                    (from tipomercancia in _context.tipomercancias
                     where (tipomercancia.Nombre.Contains(busqueda) || tipomercancia.IdTipoMercancia.ToString().Equals(busqueda))
                     select new TipoMercancia
                     {
                         IdTipoMercancia = tipomercancia.IdTipoMercancia,
                         Nombre = tipomercancia.Nombre,
                     }).ToList();

                return (listatipomercancia);
            }
        }
        public async Task<TipoMercancia> ObtenerTipoMercanciaPorID(int? id)
        {
            TipoMercancia tipomercancia = null;

            if (id == null)return tipomercancia;
            else
            {
                tipomercancia = await _context.tipomercancias.FirstOrDefaultAsync(e => e.IdTipoMercancia == id);
                return tipomercancia;
            }
        }
        public async Task GuardarEditarTipoMercancia(TipoMercancia tipomercancia)
        {
            try
            {
                if (tipomercancia.IdTipoMercancia == 0)_context.Add(tipomercancia);
                else _context.Update(tipomercancia);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public async Task EliminarTipoMercancia(TipoMercancia tipomercancia)
        {
            try
            {
                _context.tipomercancias.Remove(tipomercancia);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
