using LegoMinis.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var head = new ConstructionWorkerHead();
      head.Color = LegoColor.Yellow;

      var batmanHead = new Batman();

      var astronautHead = new Astronaut();

      var heads = new List<HeadBase>() { head, batmanHead, astronautHead };

      foreach (var legoHead in heads)
      {
        legoHead.SayHi();
      }
    }
  }
}
