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
    public class ValorLibrasController : Controller
    {
        private readonly IValorLibraBusiness _context;

        public ValorLibrasController(IValorLibraBusiness context)
        {
            _context = context;
        }

        // GET: ValorLibras
        public async Task<IActionResult> Index(string busqueda)
        {
            if (!string.IsNullOrEmpty(busqueda))
                return View(await _context.ObtenerValorLibraPorNombrePorId(busqueda));
            else
                return View(await _context.ObtenerValorLibraTodos());
        }

        // GET: ValorLibras/Create
        public async Task<IActionResult> CrearEditar(int id = 0)
        {
            if (id == 0) return View(new ValorLibra());
            else return View(await _context.ObtenerValorLibraPorID(id));
        }

        // POST: ValorLibras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearEditar([Bind("IdValorLibra,Valor")] ValorLibra valorLibra)
        {
            if (ModelState.IsValid)
            {
                await _context.GuardarEditarValorLibra(valorLibra);
                return RedirectToAction(nameof(Index));
            }
            return View(valorLibra);
        }
    }
}
