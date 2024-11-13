using System;

namespace Application.Interfaces
{
    interface IForge {
        // One forge makes one ring
        public IRing ForgeRing();
    }
}