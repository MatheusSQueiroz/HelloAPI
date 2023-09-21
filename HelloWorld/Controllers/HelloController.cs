using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace HelloWorld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }
        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Mentalidade de Crescimento\nPersistência\nResponsabilidade Pessoal\nOrientação ao Futuro\nComunicação\n" +
                "Orientação ao Detalhe\nProatividade\nTrabalho em Equipe";
        }
        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "Entender o MVC\nEntender sobre API\nEntender como funciona os protocolos\nAplicar os conceitos";
        }
    }
}
