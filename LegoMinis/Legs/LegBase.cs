using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Legs
{
  abstract class LegBase
  {
    public BottomsType Bottoms { get; set; }
    public Shoes Kicks { get; set; }

    public virtual void Dance()
    {
      Console.WriteLine("Does the two step.");
    }

    public abstract void Walk();

  }
}
