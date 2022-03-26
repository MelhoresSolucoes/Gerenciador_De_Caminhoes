using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GcApp.Data;
using GcApp.Models;
using GcApp.Utils;
using System.Net.Http;

namespace GcApp.Controllers
{
    public class CaminhaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CaminhaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Caminhao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Caminhao.ToListAsync());
         
        }

        // GET: Caminhao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caminhao = await _context.Caminhao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caminhao == null)
            {
                return NotFound();
            }

            return View(caminhao);
        }

        // GET: Caminhao/Create
        public IActionResult Create()
        {
            return View();
        }

        public async Task<bool> CreateCaminhao(Caminhao caminhao)
        {
            try
            {
                
                _context.Add(caminhao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        // POST: Caminhao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,IdModelo,AnoFabricacao,AnoModelo,DetalhesTecnicos")] Caminhao caminhao)
        {
            if (ModelState.IsValid)
            {
                if (! new ValidatorCaminhao(caminhao).ValidarAnoFabricacao()) throw new Exception("Ano de Fabricação deve ser o ano atual.");
                if (! new ValidatorCaminhao(caminhao).ValidarAnoModelo()) throw new Exception("Ano de Modelo deve ser o ano atual ou ano subsequente.");

                _context.Add(caminhao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caminhao);
        }

        // GET: Caminhao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

          
            var caminhao = await _context.Caminhao.FindAsync(id);
            if (caminhao == null)
            {
                return NotFound();
            }
            return View(caminhao);
        }

        // POST: Caminhao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,IdModelo,AnoFabricacao,AnoModelo,DetalhesTecnicos")] Caminhao caminhao)
        {
            if (id != caminhao.Id)
            {
                return NotFound();
            }

            if (! new ValidatorCaminhao(caminhao).ValidarAnoFabricacao()) throw new Exception("Ano de Fabricação deve ser o ano atual.");
            if (! new ValidatorCaminhao(caminhao).ValidarAnoModelo()) throw new Exception("Ano de Modelo deve ser o ano atual ou ano subsequente.");


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caminhao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaminhaoExists(caminhao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(caminhao);
        }

        // GET: Caminhao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caminhao = await _context.Caminhao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caminhao == null)
            {
                return NotFound();
            }

            return View(caminhao);
        }

        // POST: Caminhao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caminhao = await _context.Caminhao.FindAsync(id);
            _context.Caminhao.Remove(caminhao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaminhaoExists(int id)
        {
            return _context.Caminhao.Any(e => e.Id == id);
        }
    }
}
