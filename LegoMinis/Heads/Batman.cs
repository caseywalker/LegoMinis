using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
  class Batman : HeadBase
  {
    public bool IsWearingMask { get; set; }
    public string Version { get; set; }
    public string FacialExpression { get; set; } = "Stoic";

    public Batman()
    {
      Color = LegoColor.Black;
    }

    public override void Spin()
    {
      Console.WriteLine("Where is the Joker?!?!?!");
    }

    public override void SayHi()
    {
      Console.WriteLine("I'm Batman!");
    }
  }
}
