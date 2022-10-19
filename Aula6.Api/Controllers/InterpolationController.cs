using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Aula6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterpolationController : ControllerBase
    {

        /// <summary>
        /// const torna o campo imutável, e o seu valor deve ser atribuído no momento de sua criação
        /// </summary>
        private const string NormalString = "Este é o primeiro valor {valor1} e esté o segundo valor {valor2}.";

        [HttpGet]
        public IActionResult GetStringInterpolated(string valor1, string valor2)
        {
            var dictionary = new Dictionary<string, string>()
            { 
                { "valor1", valor1 },
                { "valor2", valor2 } 
            };
            return Ok(NormalString.LazyInterpolation(dictionary));
        }

    }

    /// <summary>
    /// Estou extendendo a classe String adicionando mais um método "LazyInterpolation" sem alterar o código original.
    /// Esso é muito usado quando queremos aplicar o conceito de open and closed do SOLID.
    /// Basicamento qualquer tipo pode ser extendido, int, decimal, InterpolationController, object
    /// </summary>
    public static class StringInterpolationExtension
    {

        /// <summary>
        /// Este tipo de polimorfismo em C# é chamado de sobrecarga de método.
        /// Mesmo método assinaturas diferentes
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Polymorphism_(computer_science)</remarks>
        /// <param name="stringTobeModified"></param>
        /// <param name="identifier"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string LazyInterpolation(this string stringTobeModified, string identifier, string value)
        {

            return stringTobeModified.Replace(identifier, value);
        }

        
        public static string LazyInterpolation(this string stringTobeModified, Dictionary<string, string> keyValuePairs)
        {

            foreach (var item in keyValuePairs)
            {
                var key = $"{{{item.Key}}}"; 
                //Usei chaves três vezes para que a primeira chave não fosse interpolada mas fose usado como uma string literal
                //resultado {valor1} ou {valor2}
                stringTobeModified = stringTobeModified.Replace(key, item.Value);
            }

            return stringTobeModified;
        }

    }
}
