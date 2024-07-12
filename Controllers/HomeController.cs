using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Lista de Clientes:
        // instancias do tipo cliente:
        Cliente cliente1 = new Cliente(01, "Guilherme", "123.456.789-00", "dev.guilhermebarbos@gmail.com", "Bisteca" );
        Cliente cliente2 = new Cliente(02, "Gabriel", "987.654.321-00", "gabriel@gmail.com", "Ze da manga");
        Cliente cliente3 = new Cliente(03, "Pedro Henrique", "123.321.456-78", "pedrodelas@gmail.com", "Biscoito");
        Cliente cliente4 = new Cliente(04, "Jorge Henrique", "456.654.321-12", "jorge@gmail.com", "Melão");
        Cliente cliente5 = new Cliente(05, "Kauan", "987.654.123-13", "kauan@gmail.com", "Scote");

        // Criando lista e adicionando os Clientes:
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        // Enviando a lista de clientes para a Views
        ViewBag.listaClientes = listaClientes;  // > ViewBag é tipo uma bolsa que vai carregar a listaClientes para o a view

        // Lista de Fornecedores:
        // Instancias do tipo fornecedor:
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        //Criando lista e adicionando os Fornecedores:
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        // Enviando a lista de fornecedores para a View
        ViewBag.listaFornecedores = listaFornecedores;  // > ViewBag é tipo uma bolsa que vai carregar a listaClientes para o a view

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
