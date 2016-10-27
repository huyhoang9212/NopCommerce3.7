using Nop.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widget.PromoSlider.Data;
using Nop.Services.Cms;
using System.Web.Routing;
using Nop.Web.Framework.Menu;
using Nop.Web.Framework;
namespace Nop.Plugin.Widget.PromoSlider
{
    public class PromoSliderPlugin : BasePlugin, IWidgetPlugin, IAdminMenuPlugin
    {
        private PromoSliderObjectContext _context;
        public PromoSliderPlugin(PromoSliderObjectContext context)
        {
            _context = context;
        }



        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }

        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "PromoSlider";
            routeValues = new RouteValueDictionary()
            {
                { "Namespaces", "Nop.Plugin.Widget.PromoSlider.Controllers" },
                { "area", null }
            };
        }

        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "PromoSliderWidget";
            controllerName = "PromoSlider";
            routeValues = new RouteValueDictionary()
            {
                { "Namespaces", "Nop.Plugin.Widget.PromoSlider.Controllers" },
                { "area", null },
                { "widgetZone", widgetZone }
            };
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string>();
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
           
            var parentNode = new SiteMapNode()
            {
                Visible = true,
                Title = "Promo Slider",
                Url = "/PromoSlider/CreateUpdatePromoSlider"
            };

            var createUpdateNode = new SiteMapNode()
            {
                Visible = true,
                Title = "New Slider",
                Url = "/PromoSlider/CreateUpdatePromoSlider"
            };

            var manageSliders = new SiteMapNode()
            {
                Visible = true,
                Title = "Manage Sliders",
                Url = "/PromoSlider/ManagePromoSliders"
            };

            parentNode.ChildNodes.Add(createUpdateNode);
            parentNode.ChildNodes.Add(manageSliders);
            rootNode.ChildNodes.Add(parentNode);
            //return parentNode;
        }
    }
}
