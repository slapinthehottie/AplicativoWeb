using AplicativoWeb.Models; //camada Model
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers;//Definindo
//Criamos a classe Controller
public class CursoController:Controller{
     public IActionResult Index(){
        Curso c1 = new Curso();
        //set
        c1.Descricao = "Primeiros Passos no ASP.NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie Aplicativos Incríveis";        
        //get
        ViewData["curso"] = c1;//passando o objeto       
        return View();
    }
    //Action
    public IActionResult Create(){
        ViewData["titulo"]="Cadastro de Cursos";
        ViewBag.DataHora = DateTime.Now;
        return View();
    }
    
}