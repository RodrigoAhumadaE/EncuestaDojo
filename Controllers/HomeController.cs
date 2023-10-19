using Microsoft.AspNetCore.Mvc;
namespace EncuestaDojo.Controllers;

public class HomeController : Controller{

    private static Dictionary<string, string> usuario = new Dictionary<string, string>(){
        {"nombre", ""},
        {"locacion", ""},
        {"lenguaje", ""},
        {"comentario", ""},
    };

    [HttpGet("")]
    public ViewResult Index(){
        return View("Index");
    }

    [HttpGet("resultado")]
    public ViewResult Resultado(){
        ViewBag.Usuario = usuario;
        return View("Resultado");
    }

    [HttpPost("nuevo/resultado")]
    public IActionResult NuevoResultado(string nombre, string locacion, string lenguaje, string comentario){
        usuario.Clear();
        usuario.Add("nombre", nombre);
        usuario.Add("locacion", locacion);
        usuario.Add("lenguaje", lenguaje);
        usuario.Add("comentario", comentario);
        return RedirectToAction("resultado");
    }
}