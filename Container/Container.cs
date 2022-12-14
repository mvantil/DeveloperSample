using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> interfaceToImplementation
                   = new Dictionary<Type, Type>();
        public void Bind(Type interfaceType, Type implementationType)
        {
            interfaceToImplementation.Add(interfaceType, implementationType);
        }

        public T Get<T>()
        {
            if (interfaceToImplementation.TryGetValue(typeof(T), out Type type))
            {
                var obj = Activator.CreateInstance(type);
                return (T)obj;
            }
            return default(T);
        }
    }
}