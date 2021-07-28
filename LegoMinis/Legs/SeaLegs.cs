using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Legs
{
  class SeaLegs : LegBase
  {
    public bool AreWobbly { get; set; }
    public int NumberOfLegs { get; set; }

    public void Swim()
    {
      Console.WriteLine("Just keep swimming");
    }
    public override void Walk()
    {
      Console.WriteLine("Walks the plank");
    }
  }
}
