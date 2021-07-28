using LegoMinis.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
  class SumoTorso : TorsoBase
  {
    public bool ChunkyDude { get; set; }
    public LegoColor FundoshiColor { get; set; }
    
    public override void Wiggle()
    {
      Console.WriteLine("Does the Shiko.");
    }

    public void FightPrep()
    {
      Console.WriteLine("Toss the salt before the fight.");
    }
  }
}
