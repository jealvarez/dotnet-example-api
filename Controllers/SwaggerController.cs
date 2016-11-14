using DotNetExampleApi.Domain;
using DotNetExampleApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetExampleApi.Controllers
{
    [Route("/")]
    public class SwaggerController : Controller
    {

        [HttpGet]
        public IActionResult RedirectToSwaggerUi()
        {
            return Redirect("/swagger/ui/index.html");
        }
    }
}
