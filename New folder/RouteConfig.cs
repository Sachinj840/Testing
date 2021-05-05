using DotNetNuke.Web.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnCall.NurseVitalsMonitoring.NurseVitalsMonitoringDashboard
{
    public class RouteConfig
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)

        {
            mapRouteManager.MapRoute("NurseVitalsMonitoringDashboard", "NurseVitalsMonitoringDashboard", "{controller}/{action}", new[] { "OnCall.NurseVitalsMonitoring.NurseVitalsMonitoringDashboard.Controllers" });
        }
    }
}