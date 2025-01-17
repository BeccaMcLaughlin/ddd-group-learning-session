using Application.Interfaces;
using Application.Rings;

namespace Application.Forges {
    class MirkwoodForge: IForge {
        public IRing ForgeRing()
        {
            return new SilverRing();
        }
    }
}