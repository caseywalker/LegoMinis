using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
  class CowboyTorso : TorsoBase
  {
    public bool HasPullString { get; set; }
    public bool HasHolster { get; set; }

    public override void Greeting()
    {
      base.Greeting();
      Console.WriteLine("There is a snake in my boot.");
    }

    public override void Wiggle()
    {
      Console.WriteLine("Draws the Colt.");
    }

    public void LassoDance()
    {
      Console.WriteLine("It's all in the wrist");
    }
  }
}
