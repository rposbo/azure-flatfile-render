using System.Web.Helpers;
using System.Web.Mvc;

namespace Render.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(string id)
        {
            var model = ProductDataService.GetById(id);
            return View(model);
        }
    }

    public static class ProductDataService
    {
        private const string DemoProductData = @"{{'name':'myproduct', 'title':'product of mine', 'price': '£25', 'id' :{0}}}";

        public static dynamic GetById(string id)
        {
            var result = Json.Decode(string.Format(DemoProductData, id));
            return result;
        }
    }
}
