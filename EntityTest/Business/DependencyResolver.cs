using System.Web.Mvc;
using Core.IRepositories;
using Core.Repositories;
using Unity;
using Unity.AspNet.Mvc;

namespace EntityTest.Business
{
    public static class DependencyResolver
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            container.RegisterType<IMessageRepository, MessageRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();
        }
    }
}