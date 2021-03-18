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
    public class TransportadorasController : Controller
    {
        private readonly ITransportadorasBusiness _context;

        public TransportadorasController(ITransportadorasBusiness context)
        {
            _context = context;
        }

        // GET: Transportadoras
        public async Task<IActionResult> Index(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
                return View(await _context.ObtenerTransportadoraPorNombrePorId(busqueda));
            else
                return View(await _context.ObtenerTransportadorasTodos());
        }
        // GET: Transportadoras/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            {
                if (id == null) return NotFound();
                var transportadoras = await _context.ObtenerTransportadoraPorID(id);
                if (transportadoras == null) return NotFound();
                return View(transportadoras);
            }
        }
            // GET: Transportadoras/Create
            public async Task<IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0) return View(new Transportadoras());
            else return View(await _context.ObtenerTransportadoraPorID(id));
        }
        // POST: Transportadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdTransportadora,Nombre")] Transportadoras transportadoras)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarTransportadora(transportadoras);
                return RedirectToAction(nameof(Index));
            }
            return View(transportadoras);
        }

        // GET: Transportadoras/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null) return NotFound();
            await _context.EliminarTransportadora(await _context.ObtenerTransportadoraPorID(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
