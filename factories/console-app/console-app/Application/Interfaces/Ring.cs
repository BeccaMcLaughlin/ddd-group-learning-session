using System;
using Application.Enums;

namespace Application.Interfaces
{
    abstract class Ring: IRing {
        public Metal Metal;
        public List<Gem> Gem = [];
        public string? Inscription;
        public List<Power> Power = [];

        public void RandomizePower()
        {
            Power = [Application.Enums.Power.Invisibility];
        }
    }
}