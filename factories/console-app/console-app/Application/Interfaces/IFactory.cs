using System;

// NAmespacing in C#
namespace Application.Interfaces
{
    // The interface is called IFactory
    interface IFactory {
        // It has one method inside called createForge that returns the Forge interface (AKA IForge)
        // The UML diagram doesn't have the argument in this method, but how can we determine what ring we want to make
        // Without an argument? Hmmmmm 🤔
        public IForge CreateForge(string ringToCreate);
    }
}