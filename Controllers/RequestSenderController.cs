using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingalRJs.Controllers
{
    public class RequestSenderController : Controller
    {
        public HubConnection hubconnection = null;
        public IHubProxy HubProxy = null;
        string SignalRCon = ConfigurationManager.AppSettings["SignalRHub"];
        // GET: Chat
        public ActionResult GetRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetRequest(FormCollection fc)
        {
            return View();
        }
    }
}