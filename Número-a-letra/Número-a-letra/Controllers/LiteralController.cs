using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Número_a_letra.Helpers;

namespace Número_a_letra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string literal_get(int numero)
        {
            return (Conversores.NumeroALetras(numero));
        }
        [HttpPost]
        public string literal_get2([FromHeader] int numero)
        {
            return (Conversores.NumeroALetras(numero));
        }
    }
}
