using Microsoft.AspNetCore.Mvc;
using PedidoCrud.Controllers;
using PedidoCrud.Models;
using System.CodeDom;
using System.Linq;

public class ProdutoController : Controller
{
    private readonly AppDbContext _context;

    public ProdutoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var produtos = _context.Produtos.ToList();
        return View(produtos);
    }

    public IActionResult Criar() => View();

    [HttpPost]
    public IActionResult Criar(Produto produto)
    {


        if (ModelState.IsValid)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(produto);
    }

   
}
