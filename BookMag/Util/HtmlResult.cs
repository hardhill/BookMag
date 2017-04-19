using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookMag.Util
{
    public class HtmlResult : ActionResult
    {
        private string htmlCode;
        public HtmlResult(string html)
        {
            htmlCode = html;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html><head>";
            fullHtmlCode += "<title>Ваш адрес</title>";
            fullHtmlCode += "<meta charset=utf-8 />";
            fullHtmlCode += "</head> <body><p>Ваш сетевой адрес:</p>";
            fullHtmlCode += htmlCode;
            fullHtmlCode += "</body></html>";
            context.HttpContext.Response.Write(fullHtmlCode);
        }

        static public string GetIp(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            return ip;
        }
    }
}