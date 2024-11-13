using System;
using Application.Forges;
using Application.Interfaces;

namespace Application {
    class Factory : IFactory
    {
        public IForge CreateForge(string ringToCreate)
        {
            IForge forge;

            switch (ringToCreate)
            {
                case "gold":
                    forge = new CelestialForge();
                    break;
                case "silver":
                    forge = new MirkwoodForge();
                    break;
                case "platinum":
                    forge = new MirrorstoneHallForge();
                    break;
                default:
                    throw new Exception();
            }

            return forge;
        }
    }
}