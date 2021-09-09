using System.Web.Http;
using Unity;
using Unity.WebApi;
using Unity.Lifetime;
using PickupPointsAPIHelper.RestClientLogic.Interfaces;
using PickupPointsAPIHelper.RestClientLogic.Implementations;
using PickupPointsAPIHelper.ApiHelperLogic.Interfaces;
using PickupPointsAPIHelper.ApiHelperLogic.Implementations;

namespace PickupPoints
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IRestClientHelper, RestClientHelper>(new HierarchicalLifetimeManager());
            container.RegisterType<IApiHelperLogic, ApiHelperLogic>(new HierarchicalLifetimeManager());

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}