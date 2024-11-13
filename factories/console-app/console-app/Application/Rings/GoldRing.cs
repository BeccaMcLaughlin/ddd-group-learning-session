using System;
using Application.Interfaces;
using Application.Enums;

namespace Application.Rings {
    class GoldRing: Ring {
        public GoldRing()
        {
            Metal = Metal.Gold;
            Gem = [Application.Enums.Gem.Diamond];
            RandomizePower();
            Inscription = "Im'll gar- i gwanod leben haer";
        }
    }
}