using DependencyInjectionDemo.Controllers;
using DependencyInjectionDemo.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace DependencyInjectionDemo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IEmployee, EmployeeRepository>();
            container.RegisterType<Interface1, Sample>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}