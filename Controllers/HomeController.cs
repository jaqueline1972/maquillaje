using Microsoft.AspNetCore.Mvc;
using maquillaje.Models;

namespace maquillaje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ofertas = new List<Producto>
            {
                new Producto { Nombre = "Kit Maquillaje Glam Complete", Categoria = "Set Especial 25% OFF", Precio = "$450.00", Imagen = "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?q=80&w=600" },
                new Producto { Nombre = "Set Brochas Profesionales (12 pzs)", Categoria = "Oferta Limitada", Precio = "$280.00", Imagen = "https://images.unsplash.com/photo-1596462502278-27bfdc403348?q=80&w=600" },
                new Producto { Nombre = "Trio Labiales Velvet Matte", Categoria = "Bestseller", Precio = "$320.00", Imagen = "https://images.unsplash.com/photo-1586495777744-4413f21062fa?q=80&w=600" }
            };

            return View(ofertas);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(string nombre, string email, string tipoConsulta, string tonoPiel, string mensaje)
        {
            ViewBag.Mensaje = $"¡Gracias {nombre}! Hemos recibido tu consulta sobre '{tipoConsulta}'. Te contactaremos a {email} a la brevedad.";
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }
    }
}