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
        //Instancias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Arthur A.Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Emereciano Silva", "111.111.111-11", "emereciano@sp.senai.br", "Bob");
        Cliente cliente3 = new Cliente(03, "Josuel Nascimento", "222.222.222-22", "josuel@sp.senai.br", "Maylon");
        Cliente cliente4 = new Cliente(04, "Alberto Silva", "333.333.333-33", "alberto@sp.senai.br", "Brutos");
        Cliente cliente5 = new Cliente(05, "Sonia Coutinho", "444.444.444-44", "sonia@sp.senai.br", "Pingo");

        //lista de clientes e atribuir os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        
        
        //Instancias do tipo Fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "CH PET S/A", "14.182.102/0001-00", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik tok Dogs", "87.945.350/0001-09", "noisnamidia@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@pet.org");

        //lista de Fornecedor e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); 
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
