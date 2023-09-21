using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return ("Hello World!");
        }

        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Gabriel";
        }

        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Responsabilidade pessoal \nMentalidade de crescimento \nOrientação ao futuro \nPersistência \nComunicação \nOrientação aos Detalhes \nTrabalho em equipe \nProatividade";
        }

        [HttpGet("/semanal")]
        public string Semanal()
        {
            return "Aprender sobre conceitos importantes antes de começar a cordar de fato";
        }
    }
}
