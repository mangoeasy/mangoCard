using System.Web.Mvc;
using Mango_Cards.Library.Services;
using Mango_Cards.Service.Services;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.Mvc5;

namespace Mango_Cards.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);

            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

            container.RegisterType<IAccountService, AccountService>();
        }
    }
}