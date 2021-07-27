using LegoMinis.Heads;
using System;

namespace LegoMinis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var head = new ConstructionWorkerHead();
      head.Color = LegoColor.Yellow;

    }
  }
}
