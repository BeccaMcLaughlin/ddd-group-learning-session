using System;
using Application.Interfaces;
using Application.Enums;
using Application.Rings;

namespace Application.Forges {
    class MirkwoodForge: IForge {
        public IRing ForgeRing()
        {
            return new GoldRing();
        }
    }
}