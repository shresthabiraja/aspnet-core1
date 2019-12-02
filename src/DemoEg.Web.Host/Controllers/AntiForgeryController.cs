using Microsoft.AspNetCore.Antiforgery;
using DemoEg.Controllers;

namespace DemoEg.Web.Host.Controllers
{
    public class AntiForgeryController : DemoEgControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
