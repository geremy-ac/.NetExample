using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCORE_CRUD_991.Clases;
using NETCORE_CRUD_991.Models.Abstract;
using NETCORE_CRUD_991.Models.DAL;
using NETCORE_CRUD_991.Models.Entities;

namespace NETCORE_CRUD_991.Controllers
{
    public class PaquetesController : Controller
    {
        private readonly IPaqueteBusiness _context;

        public PaquetesController(IPaqueteBusiness context)
        {
            _context = context;
        }

        // GET: Paquetes
        public async Task<IActionResult> Index(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
                return View(await _context.ObtenerPaquetePorCasilleroPorCodigo(busqueda));
            else
                return View(await _context.ObtenerPaqueteTodos());
        }

        // GET: Paquetes/Details/5
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paquete = await _context.ObtenerPaqueteDetalleTodos(id);
            if (paquete == null)
            {
                return NotFound();
            }

            return View(paquete);
        }


        // GET: Paquetes/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            IEnumerable<Cliente> listaclientes = await _context.ObtenerClienteTodos();
            IEnumerable<Transportadoras> listatransportadoras = await _context.ObtenerTransportadoraTodos();
            IEnumerable<TipoMercancia> listatipomercancias = await _context.ObtenerTipoMercanciaTodos();
            IEnumerable<ValorLibra> listavalorlibra = await _context.ObtenerValorLibraTodos();
            ViewBag.Cliente = listaclientes;
            ViewBag.ValorLibra = listavalorlibra;
            ViewBag.Transportadoras = listatransportadoras;
            ViewBag.TipoMercancia = listatipomercancias;

            if (id == 0)
                return View(new Paquete());
            else
                return View(await _context.ObtenerPaquetePorCodigo(id));
        }
        // POST: Paquetes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdPaquete,CodigoPaquete,PesoLibra,IdCliente,IdValorLibra,Estado,USA,IdTransportadora,IdTipoMercancia,COL,ValorPagar")] Paquete paquete)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarPaquete(paquete);
                return RedirectToAction(nameof(Index));
            }
            return View(paquete);
        }

        // GET: Paquetes/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null) return NotFound();
            await _context.EliminarPaquete(await _context.ObtenerPaquetePorCodigo(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
