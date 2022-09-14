using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = 
        new List<EstudanteViewModel>
        {
            new EstudanteViewModel(1, "Camila", "R. Frutas, n.6", true),
            new EstudanteViewModel(2, "Paula", "R. Salada, n.3", false),
            new EstudanteViewModel(3, "Luciene", "R. Doces, n.7", true),
        };
    public IActionResult Index ()
    {
        return View(estudantes);
    }
    public IActionResult Show (int id)
    {
       // var estudante = new EstudanteViewModel(5, "Latorre", "Rua Java, n. 11", false);
        return View(estudantes[id-1]);
    }
}