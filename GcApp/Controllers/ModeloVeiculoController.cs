using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GcApp.Data;
using GcApp.Models;

namespace GcApp.Controllers
{
    public class ModeloVeiculoController: Controller
    {
        private readonly ApplicationDbContext _context;

        public ModeloVeiculoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ModeloVeiculo
        public async Task<IActionResult> Index()
        {
            return View(await _context.ModeloVeiculo.ToListAsync());
         
        }

        // GET: ModeloVeiculo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVeiculo = await _context.ModeloVeiculo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modeloVeiculo == null)
            {
                return NotFound();
            }

            return View(modeloVeiculo);
        }

        // GET: ModeloVeiculo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ModeloVeiculo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Bloqueado")] ModeloVeiculo modeloVeiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modeloVeiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modeloVeiculo);
        }

        // GET: ModeloVeiculo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVeiculo = await _context.ModeloVeiculo.FindAsync(id);
            if (modeloVeiculo == null)
            {
                return NotFound();
            }
            return View(modeloVeiculo);
        }

        // POST: ModeloVeiculo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Bloqueado")] ModeloVeiculo modeloVeiculo)
        {
            if (id != modeloVeiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modeloVeiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModeloVeiculoExists(modeloVeiculo.Id))
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
            return View(modeloVeiculo);
        }

        // GET: ModeloVeiculo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modeloVeiculo = await _context.ModeloVeiculo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (modeloVeiculo == null)
            {
                return NotFound();
            }

            return View(modeloVeiculo);
        }

        // POST: ModeloVeiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modeloVeiculo = await _context.ModeloVeiculo.FindAsync(id);
            _context.ModeloVeiculo.Remove(modeloVeiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModeloVeiculoExists(int id)
        {
            return _context.ModeloVeiculo.Any(e => e.Id == id);
        }
    }
}
