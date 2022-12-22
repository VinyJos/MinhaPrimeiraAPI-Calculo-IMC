using Microsoft.AspNetCore.Mvc;

namespace ApiIMC.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ImcController : ControllerBase
    {   
        [HttpGet("CalculoImc/{peso}/{altura}")]
        public IActionResult CalculoImc(float peso, float altura)
        {   
            var calcularImc = peso / (altura * altura);

            return Ok(calcularImc.ToString("N2"));
        }
    }
}