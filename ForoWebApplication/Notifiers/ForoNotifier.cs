using ForoWebApplication.Hubs;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForoWebApplication.Notifiers
{
    public class ForoNotifier
    {
        private Microsoft.AspNet.SignalR.Hubs.IHubConnectionContext<dynamic> _clientNotifier;
        public ForoNotifier()
        {
            _clientNotifier = GlobalHost.ConnectionManager.GetHubContext<ForoHub>().Clients;
        }

        public void NotifyEvent(string message)
        {
            _clientNotifier.All.addMessage("Admin", message);
        }

        public void WarningEvent(string message)
        {
            _clientNotifier.All.warningMessage(message);
        }
    }
}