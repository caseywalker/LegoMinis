using LegoMinis.Heads;
using LegoMinis.Legs;
using LegoMinis.Minifigures;
using LegoMinis.Torsos;
using System;
using System.Collections.Generic;

namespace LegoMinis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var head = new ConstructionWorkerHead();
      head.Color = LegoColor.Yellow;

      var batmanHead = new Batman();

      var astronautHead = new Astronaut();

      var heads = new List<HeadBase>() { head, batmanHead, astronautHead };

      foreach (var legoHead in heads)
      {
        legoHead.SayHi();
      }

      var batsuit = new Batsuit();
      batsuit.TorsoColor = LegoColor.Black;
      batsuit.HasBatBoomerang = true;
      batsuit.HasShirt = false;
      batsuit.Donates();

      var woody = new CowboyTorso();

      var sumo = new SumoTorso();

      var torsos = new List<TorsoBase>() { batsuit, woody, sumo };

      foreach (var torso in torsos)
      {
        torso.Greeting();
        torso.Wiggle();
      }

      var squidward = new SeaLegs();
      squidward.AreWobbly = true;
      squidward.Bottoms = BottomsType.Chaps;
      squidward.Kicks = Shoes.Sandals;
      squidward.NumberOfLegs = 3;

      var genie = new MagicLegs();
      genie.Bottoms = BottomsType.None;
      genie.Kicks = Shoes.ShelltoeAdidas;
      genie.HasInvisibleLegs = true;
      genie.MeasuringLegs("large");

      var legs = new List<LegBase>() { squidward, genie };

      foreach (var leg in legs)
      {
        leg.Walk();
        leg.Dance();
      }

      var bob = new Minifigure(head, woody, squidward);
      bob.BuildIt();
      bob.Leg.Dance();


    } 
  }
}
