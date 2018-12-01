using DiscordBot.Storage.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;

namespace DiscordBot
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>();
        }
        public static T Resolve<T>()
        {
            return (T)container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }

    }
}
