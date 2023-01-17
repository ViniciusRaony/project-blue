﻿using Microsoft.AspNetCore.Mvc;

namespace Blue.Controllers
{
    [ApiController]
    [Route("")] // Health check - Rota padrão raíz para outras APIs checarem se essa API está OK (ping)
    public class HomeController : ControllerBase
    {
        [HttpGet("")] // Health check - Raíz da raíz de qualquer porta
        public IActionResult Get()
        {
            return Ok();
            /*return Ok(new    // Pode retorna versão da API, por exemplo. Transforma para JSON
            {
                fruta = "banana"
            });*/
        }
    }
}
