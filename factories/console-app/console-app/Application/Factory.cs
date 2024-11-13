using System;
using Application.Forges;
using Application.Interfaces;

namespace Application {
    class Factory : IFactory
    {
        public IForge CreateForge(string ringToCreate)
        {
            if (ringToCreate == "gold") {
                return new MirkwoodForge();
            }

            throw new Exception();
        }
    }
}