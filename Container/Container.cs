using System;

namespace DeveloperSample.Container
{
    public class Container
    {
        public void Bind(Type interfaceType, Type implementationType) => throw new NotImplementedException();
        public T Get<T>() => throw new NotImplementedException();
    }
}