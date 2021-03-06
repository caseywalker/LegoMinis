using LegoMinis.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
  abstract class TorsoBase
  {
    public bool HasShirt { get; set; }
    public LegoColor TorsoColor { get; set; }
    public string ToolBelt { get; set; }

    public virtual void Greeting()
    {
      Console.WriteLine("Give a high five.");
    }

    public abstract void Wiggle();
  }
}
