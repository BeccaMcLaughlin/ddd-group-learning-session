using Application.Interfaces;
using Application.Rings;

namespace Application.Forges {
    class MirrorstoneHallForge: IForge {
        public IRing ForgeRing()
        {
            return new PlatinumRing();
        }
    }
}