using System;
using Application.Interfaces;
using Application.Enums;

namespace Application.Rings {
    class PlatinumRing: Ring {
        public PlatinumRing()
        {
            Metal = Metal.Platinum;
            Gem = [Application.Enums.Gem.Ruby];
            RandomizePower();
            Inscription = "estel i aes doesn't nor- awaui";
        }
    }
}