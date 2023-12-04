using System;
using System.Linq;

namespace DeveloperSample.Algorithms {
  public static class Algorithms {

    public static int GetFactorial(int num) {
      var factorial = num;

      for (int i = num - 1; i > 0; i--) {
        factorial *= i;
      }

      return factorial;
    }

    public static string FormatSeparators(params string[] chars) {
      var lastItem = chars[chars.Length - 1];
      var rest = chars.Take(chars.Length - 1);

      return $"{string.Join(", ", rest)} and {lastItem}";
    }

  }
}