using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace api
{
    public static class Decisions
    {
        [FunctionName("decisions")]
        public static Task<IActionResult> get(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            return Task.FromResult<IActionResult>(new OkObjectResult("success"));
        }
    }
}
