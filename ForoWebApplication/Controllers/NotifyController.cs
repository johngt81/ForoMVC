using ForoWebApplication.Notifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForoWebApplication.Controllers
{
    public class NotifyController : Controller
    {
        [HttpPost]
        public void ReportEvent(string message)
        {
            var notifier = new ForoNotifier();
            notifier.NotifyEvent(message);
        }

        [HttpPost]
        public void WarningEvent(string message)
        {
            var notifier = new ForoNotifier();
            notifier.WarningEvent(message);
        }
	}
}