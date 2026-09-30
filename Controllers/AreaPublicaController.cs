using Microsoft.AspNetCore.Mvc;
using Renato_Origuela.Models;

namespace Renato_Origuela.Controllers
{
    public class AreaPublicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Acessorios()

        {

            Carro c1 = new Carro();
            c1.Nome = "bMW";
            c1.Descricao = "Sedã esportivo";
            c1.Ano = 2018;
            c1.Quilometragem = 18000;
            c1.Cambio = "Automatico";
            c1.Preco = 210000;

            Carro c2 = new Carro();
            c2.Nome = "fiat";
            c2.Descricao = "hatch esportivo";
            c2.Ano = 2020;
            c2.Quilometragem = 88000;
            c2.Cambio = "Automatico";
            c2.Preco = 250000;

            Carro c3 = new Carro();
            c3.Nome = "Mercedes";
            c3.Descricao = "Sedã ";
            c3.Ano = 2005;
            c3.Quilometragem = 8775000;
            c3.Cambio = "Manual";
            c3.Preco = 910000;
            List<Carro> ListaCarros = new List<Carro>();

            ListaCarros.Add(c1);
            ListaCarros.Add(c2);
            ListaCarros.Add(c3);

            return View(ListaCarros);

        }
        public IActionResult Login()


        {
            return View();
        }


    }
}
