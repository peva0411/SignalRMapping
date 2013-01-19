using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRMapping.Hubs
{
    public class MapUpdate : Hub
    {
        public void UpdateMapMessage(string message)
        {
            Clients.All.displayMapMessage(message);
        }

        public void UpdateMapExtent(double xMin, double yMin, double xMax, double yMax)
        {
            Clients.Others.setMapExtent(xMin, yMin, xMax, yMax);
        }

    }

}