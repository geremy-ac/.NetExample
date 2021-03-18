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
    public class ClientesController : Controller
    {
        private readonly IClienteBusiness _context;

        public ClientesController(IClienteBusiness context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
                return View(await _context.ObtenerClientePorNombrePorCasillero(busqueda));
            else
                return View(await _context.ObtenerClienteTodos());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Detalle(int? id)
        {
            if (id == null) return NotFound();
            var cliente = await _context.ObtenerClientePorCasillero(id);
            if (cliente == null) return NotFound();
            return View(cliente);
        }

        // GET: Clientes/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0) return View(new Cliente());
            else return View(await _context.ObtenerClientePorCasillero(id));
        }
        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdCliente,Nombre,Correo,Direccion")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null) return NotFound();
            await _context.EliminarCliente(await _context.ObtenerClientePorCasillero(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
