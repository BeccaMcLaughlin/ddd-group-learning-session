using System;
using Application.Interfaces;
using Application.Enums;

namespace Application.Rings {
    class SilverRing: Ring {
        public SilverRing()
        {
            Metal = Metal.Silver;
            Gem = [Application.Enums.Gem.Emerald];
            RandomizePower();
            Inscription = "estel i aes doesn't nor- awaui";
        }
    }
}