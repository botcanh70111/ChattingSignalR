using System.Web.Mvc;
using Core.IRepositories;
using Core.Repositories;
using Unity;
using Unity.AspNet.Mvc;

namespace EntityTest.Business
{
  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));
      container.RegisterType<IMessageRepository, MessageRepository>();
    }
  }
}