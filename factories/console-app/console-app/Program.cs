using Application;
using Application.Interfaces;

Factory factory = new Factory();

// Pass string I want
List<string> ringsToCreate = ["gold", "silver", "platinum", "BLOOD"];

foreach (string ringAsString in ringsToCreate)
{
    IForge forge = factory.CreateForge(ringAsString);
    IRing ring = forge.ForgeRing();
    Console.WriteLine(ring.ToString());
}


