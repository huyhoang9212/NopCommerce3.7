using Nop.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Cms;
using System.Web.Routing;

namespace Nop.Plugin.Widgets.PromoSlider
{
    public class PromoSliderPlugin2 : BasePlugin, IWidgetPlugin
    {
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            throw new NotImplementedException();
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            throw new NotImplementedException();
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string>();
        }

    }
}
