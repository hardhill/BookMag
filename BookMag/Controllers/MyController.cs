using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookMag.Controllers
{
    public class MyController:IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var response = requestContext.HttpContext.Response;
            response.Write("<h3>Ваш ip адрес: "+ip+"</h3>");
        }
    }
}