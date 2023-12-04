using System;
using System.Collections.Generic;

namespace DeveloperSample.Container {

  public class Container {

    public IDictionary<Type, object> dictionary = new Dictionary<Type, object>();

    public void Bind(Type interfaceType, Type implementationType) {
      object instance = Activator.CreateInstance(implementationType);
      dictionary.Add(interfaceType, instance);
    }

    public T Get<T>() {
      return (T)dictionary[typeof(T)];
    }
    
  }
}