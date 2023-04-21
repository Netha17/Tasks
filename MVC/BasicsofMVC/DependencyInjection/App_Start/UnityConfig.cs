using BussinessLayer;
using System;
using DAL;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace DependencyInjection
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {

        public static void RegisterComponents()
        {
            var container=new UnityContainer();

            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            
            container.RegisterType<Employee>();
            container.RegisterType<IDataAccessLayer,EmployeeDAL>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}