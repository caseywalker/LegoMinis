﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
  class ConstructionWorkerHead
  {
    public bool HasMullet { get; set; }
    public LegoColor Color { get; set; }
    public int NumberOfTeeth { get; set; }
    public bool WearingHardHat { get; set; }

    public bool ToggleWorking()
    {
      WearingHardHat = !WearingHardHat;
      Console.WriteLine($"The constructor worker head {(WearingHardHat ? "is" : "is not")} wearing their hard hat.");
      return WearingHardHat;
    }

    public void Spin()
    {
      if(NumberOfTeeth > 0)
      {
        NumberOfTeeth -= 1;
      }
      Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
    }

    public void SayHi()
    {
      Console.WriteLine($"The Construction Worker Head says hello");
    }
  }
  enum LegoColor
  {
    Yellow,
    White,
    Brown,
    Green,
    Red
  }

}
