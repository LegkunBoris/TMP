using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Ninject.Modules;
using CardSystem.BLL;
using Ninject.Web.WebApi;

namespace CardSystem.WEB
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			NinjectModule webModule = new WEBModule();
			NinjectModule bllModule = new BLLModule("DefaultConnection");

			var kernel = new Ninject.StandardKernel(webModule, bllModule);
			DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
		}
	}
}
