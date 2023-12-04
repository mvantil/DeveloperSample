using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DeveloperSample.Syncing {
  public class SyncDebug {

    public List<string> InitializeList(IEnumerable<string> items) {
      var cb = new ConcurrentBag<string>();

      Parallel.ForEach(items, i => {
        cb.Add(i);
      });

      return cb.ToList();
    }

    public Dictionary<int, string> InitializeDictionary(Func<int, string> getItem) {
      var itemsToInitialize = Enumerable.Range(0, 100).ToList();

      var concurrentDictionary = new ConcurrentDictionary<int, string>();
      var threads = Enumerable.Range(0, 3).Select(i => new Thread(() => {
        itemsToInitialize.ForEach(item => {
          lock(concurrentDictionary) {
            concurrentDictionary.AddOrUpdate(item, getItem, (_, s) => s);
          }
        });
      })).ToList();

      threads.ForEach(t => t.Start());
      threads.ForEach(t => t.Join());

      return concurrentDictionary.ToDictionary(entry => entry.Key, entry => entry.Value);
    }
  }
}