using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp1
{
    public static class BDCOLECFunction
    {
        [FunctionName ("BDCOLECFunction")]
        public static async Task<IActionResult> Run (
            [HttpTrigger (AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log ) // Only posts trigger
        {
            log.LogInformation ("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

            //string HMNCODIG = req.Query["HMNCODIG"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject<DeserializeJsonTrigger>(requestBody); // Faz retornar o objeto da forma que preciso
            Console.WriteLine (data);
            //HMNCODIG = HMNCODIG ?? data?.HMNCODIG;


            //name = name ?? data?.name;
            //var teste = data.name; 

            return new OkObjectResult ($"data = {data.body.HMHCODIG}");

            //return name != null
            //    ? (ActionResult)new OkObjectResult($"Hello, {name}")
            //    : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }

    public class DeserializeJsonTrigger
    {
        public BodyContent body { get; set; }
    }

    public class BodyContent
    {
        //"HMHCODIG": "teste",
        public string HMHCODIG { get; set; }
        //"HMTDTLIN": "2020-01-28T19:24:08.0100000",
        public DateTime HMTDTLIN { get; set; }
        //"HMTDTLFI": "2020-01-28T19:24:08.0100000",
        public DateTime HMTDTLFI { get; set; }
        //"HMNIDCCS": 50,
        public int HMNIDCCS { get; set; }
        //"HMNIDEVC": 10,a
        public string HMNIDEVC { get; set; }
        //"HM8CODSA": "as",
        public string HM8CODSA { get; set; }
        //"HMNINDGB": 12,
        public int HMNINDGB { get; set; }
        //"HMNDTUCO": "2020-01-28T19:24:08.0100000",
        public DateTime HMNDTUCO { get; set; }
        //"HMOIDLIC": 5666773,
        public double HMOIDLIC { get; set; }
    }
}
