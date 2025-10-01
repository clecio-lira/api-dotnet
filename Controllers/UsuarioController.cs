using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterDataHota()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var msg = $"Olá {nome} seja bem vindo";

            return Ok(new { msg });
        }
    }
}