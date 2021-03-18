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

    public class ValorLibraBusiness : IValorLibraBusiness
    {
        private readonly DbContextPrueba _context;

        public ValorLibraBusiness(DbContextPrueba context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ValorLibra>> ObtenerValorLibraTodos()
        {
           return (await _context.valorlibra.ToListAsync());
        }
        public async Task<IEnumerable<ValorLibra>> ObtenerValorLibraPorNombrePorId(string busqueda)
        {
            await using (_context)
            {
                IEnumerable<ValorLibra> listavalorlibra =
                    (from valorlibra in _context.valorlibra
                     where (valorlibra.Valor.ToString().Equals(busqueda) || valorlibra.IdValorLibra.ToString().Equals(busqueda))
                     select new ValorLibra
                     {
                         IdValorLibra = valorlibra.IdValorLibra,
                         Valor = valorlibra.Valor,
                     }).ToList();

                return (listavalorlibra);
            }
        }
        public async Task<ValorLibra> ObtenerValorLibraPorID(int? id)
        {
            ValorLibra valorLibra = null;

            if (id == null)return valorLibra;
            else
            {
                valorLibra = await _context.valorlibra.FirstOrDefaultAsync(e => e.IdValorLibra == id);
                return valorLibra;
            }
        }
        public async Task GuardarEditarValorLibra(ValorLibra valorLibra)
        {
            try
            {
                if (valorLibra.IdValorLibra == 0)_context.Add(valorLibra);
                else _context.Update(valorLibra);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
