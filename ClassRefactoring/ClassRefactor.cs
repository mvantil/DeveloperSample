using System;

namespace DeveloperSample.ClassRefactoring {

  // ideally I'd probably not use enums in favor of interfaces and backing concrete objects.
  public enum SwallowType {
    African = 22, 
    European = 20
  }

  public enum SwallowLoad {
    None = 0, 
    Coconut = 4
  }

  public class SwallowFactory {
    public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
  }

  public class Swallow {
    public SwallowType Type { get; }
    public SwallowLoad Load { get; private set; }

    public Swallow(SwallowType swallowType) => Type = swallowType;

    public void ApplyLoad(SwallowLoad load) => Load = load;

    public double GetAirspeedVelocity() {
      try {
        // not too disimilar of a way to handle based on interface as well.
        // offloads giving a darn about the 'what' and 'how fast' and 'load carried'
        return (int)Type - (int)Load;
      } catch {
        // eh... should catch then log error etc. 
        // or at the very least throw a specific error...
        throw new InvalidOperationException("Unexpected airspeed velocity for Swallow Load");
      }
    }
  }
}