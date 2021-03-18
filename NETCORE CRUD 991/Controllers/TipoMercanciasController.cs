using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCORE_CRUD_991.Models.Abstract;
using NETCORE_CRUD_991.Models.DAL;
using NETCORE_CRUD_991.Models.Entities;

namespace NETCORE_CRUD_991.Controllers
{
    public class TipoMercanciasController : Controller
    {
        private readonly ITipoMercanciaBusiness _context;

        public TipoMercanciasController(ITipoMercanciaBusiness context)
        {
            _context = context;
        }

        // GET: TipoMercancias
        public async Task<IActionResult> Index(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
                return View(await _context.ObtenerTipoMercanciaPorNombrePorId(busqueda));
            else
                return View(await _context.ObtenerTipoMercanciaTodos());
        }
        // GET: TipoMercancias/Details/5
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null) return NotFound();
            var tipomercancia = await _context.ObtenerTipoMercanciaPorID(id);
            if (tipomercancia == null) return NotFound();
            return View(tipomercancia);
        }

        // GET: TipoMercancias/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0) return View(new TipoMercancia());
            else return View(await _context.ObtenerTipoMercanciaPorID(id));
        }

        // POST: TipoMercancias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdTipoMercancia,Nombre")] TipoMercancia tipomercancia)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarTipoMercancia(tipomercancia);
                return RedirectToAction(nameof(Index));
            }
            return View(tipomercancia);
        }
        // GET: TipoMercancias/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null) return NotFound();
            await _context.EliminarTipoMercancia(await _context.ObtenerTipoMercanciaPorID(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
