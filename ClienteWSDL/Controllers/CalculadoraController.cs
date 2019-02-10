using CalculadoraWS;
using Microsoft.AspNetCore.Mvc;

namespace ClienteWSDL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        // GET api/values
        [HttpGet("{op}/{arg1}/{arg2}")]
        public ActionResult<int> Get([FromServices] CalculatorSoap calculadora, TipoOperacion op, int arg1, int arg2)
        {
            switch (op)
            {
                case TipoOperacion.Add:
                    return calculadora.AddAsync(arg1, arg2).Result;
                case TipoOperacion.Subtract:
                    return calculadora.SubtractAsync(arg1, arg2).Result;
                case TipoOperacion.Multiply:
                    return calculadora.MultiplyAsync(arg1, arg2).Result;
                case TipoOperacion.Divide:
                    return calculadora.DivideAsync(arg1, arg2).Result;
            }
            return 0;
        }
    }
}
