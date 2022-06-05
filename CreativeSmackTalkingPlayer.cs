using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt {get;set;}

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            System.Console.WriteLine($"{Name} taunts: {Taunt[new Random().Next(Taunt.Count)]}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}