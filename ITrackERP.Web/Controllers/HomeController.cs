using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ITrackERP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ITrackERPControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}