using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
  class Batman
  {
    public bool IsWearingMask { get; set; }
    public string Version { get; set; }
    public string FacialExpression { get; set; } = "Stoic";

    public void Spin()
    {
      Console.WriteLine("Where is the Joker?!?!?!");
    }

    public void SayHi()
    {
      Console.WriteLine("I'm Batman!");
    }
  }
}
