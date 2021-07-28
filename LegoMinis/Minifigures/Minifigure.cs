using LegoMinis.Heads;
using LegoMinis.Legs;
using LegoMinis.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Minifigures
{
  class Minifigure
  {
    public HeadBase Head { get; }
    public TorsoBase Torso { get; }
    public LegBase Leg { get; }

    public Minifigure(HeadBase head, TorsoBase torso, LegBase leg)
    {
      Head = head;
      Torso = torso;
      Leg = leg;
    }

    public void BuildIt()
    {
      Console.WriteLine("Building stuff.");
    }

  }
}
