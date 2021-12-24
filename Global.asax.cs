using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
namespace Lquizzes.com
{

    public class MvcApplication : System.Web.HttpApplication
    {
        public static List<Quiz> quizzes;
        protected void Application_Start()
        {
            Quiz temp;
            string path = Server.MapPath("~/App_Data/quizzes.json");
            string jsontext = System.IO.File.ReadAllText(path);
            quizzes = JsonConvert.DeserializeObject<Quizzes>(jsontext).quizzes;
                    
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
