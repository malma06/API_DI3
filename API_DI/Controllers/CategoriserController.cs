using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriserController : ControllerBase
    {
        // GET api/Categoriser
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2","value preuve", "preuve developper" };
        }

        // GET api/Categoriser/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// demander la categorie de la demande
        /// </summary>
        /// <remarks>demander à l&#39;API la categorie de la demande selon les quatre code de chaqun de les process de identification.</remarks>
        /// <param name="code1">code de validation des reinsegments de la demande de place</param>
        /// <param name="code2">code de validation des possibles services de garde pour la demande</param>
        /// <param name="code3">code de validation de localisation des possibles services de garde pour la demande</param>
        /// <param name="code4">code de validation de l&#39;identification de l-enfant de la demande de place</param>
        /// <response code="200">OK</response>
        /// <response code="400">bad input parameter</response>
        //[HttpGet]
        //[Route("/malma06/categorisation-api/1.0.0/categoriser")]
        //[ValidateModelState]
        //[SwaggerOperation("CategoriserGet")]
        //[SwaggerResponse(statusCode: 200, type: typeof(CategorieDemande), description: "OK")]
        //public virtual IActionResult CategoriserGet([FromQuery][Required()]string code1, [FromQuery][Required()]string code2, [FromQuery][Required()]string code3, [FromQuery][Required()]string code4)
        //public ActionResult<string> CategoriserGet()
        //{
        //    //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(200, default(CategorieDemande));

        //    //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
        //    // return StatusCode(400);

        //    //string exampleJson = null;
        //    //exampleJson = "{\n  \"name\" : \"Fiable\",\n  \"description\" : \"Correct pour tous les validations\",\n  \"id\" : \"1\"\n}";

        //    //var example = exampleJson != null
        //    //? JsonConvert.DeserializeObject<CategorieDemande>(exampleJson)
        //    //: default(CategorieDemande);
        //    ////TODO: Change the data returned
        //    //return new ObjectResult(example);

        //    return "value";


        //}

    }
}
