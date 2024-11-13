using Application.Interfaces;
using Application.Rings;

namespace Application.Forges {
    class CelestialForge: IForge {
        public IRing ForgeRing()
        {
            return new GoldRing();
        }
    }
}