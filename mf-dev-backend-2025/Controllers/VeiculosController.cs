using mf_dev_backend_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace mf_dev_backend_2025.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;

       public VeiculosController(AppDbContext Context)
        {
            _context = Context;
        }
        public AppDbContext Context => _context;

        public async Task<IActionResult> Index()
        {

            var dados = await Context.Veiculos.ToListAsync();
            return View(dados);
        }
    }
}
