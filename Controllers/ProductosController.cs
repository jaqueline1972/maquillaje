using Microsoft.AspNetCore.Mvc;
using maquillaje.Models;

namespace maquillaje.Controllers
{
    public class ProductosController : Controller
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Paleta Sombras Glam Palette", Categoria = "Ojos", Precio = "$290.00", Imagen = "https://images.unsplash.com/photo-1512496015851-a90fb38ba796?q=80&w=600" },
            new Producto { Nombre = "Base Hydra Velvet (24h)", Categoria = "Rostro", Precio = "$260.00", Imagen = "https://images.unsplash.com/photo-1631729371254-42c2892f0e6e?q=80&w=600" },
            new Producto { Nombre = "Gloss Hidratante Plumpling", Categoria = "Labios", Precio = "$160.00", Imagen = "https://images.unsplash.com/photo-1586495777744-4413f21062fa?q=80&w=600" },
            new Producto { Nombre = "Serum Iluminador Vitamina C", Categoria = "Skincare", Precio = "$340.00", Imagen = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?q=80&w=600" },
            new Producto { Nombre = "Delineador Waterproof Precision", Categoria = "Ojos", Precio = "$180.00", Imagen = "https://images.unsplash.com/photo-1596462502278-27bfdc403348?q=80&w=600" },
            new Producto { Nombre = "Blush Líquido Soft Touch", Categoria = "Rostro", Precio = "$210.00", Imagen = "https://images.unsplash.com/photo-1522337360788-8b13dee7a37e?q=80&w=600" }
        };

        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Detalle(string nombre)
        {
            var p = productos.FirstOrDefault(x => x.Nombre == nombre) ?? productos[0];
            return View(p);
        }
    }
}