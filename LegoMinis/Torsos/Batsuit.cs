using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
  class Batsuit : TorsoBase
  {
    public bool HasBatBoomerang { get; set; }

    public override void Greeting()
    {
      base.Greeting();
      Console.WriteLine("Answers the Bat Signal.");
    }

    public override void Wiggle()
    {
      Console.WriteLine("Flex on em!");
    }

    public void Donates()
    {
      Console.WriteLine("Donates to a good cause");
    }
  }
}
