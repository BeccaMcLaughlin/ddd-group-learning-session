using Application;
using Application.Interfaces;

Factory factory = new Factory();

// Pass string I want
string ringToCreate = "gold";

IForge forge = factory.CreateForge(ringToCreate);
IRing ring = forge.ForgeRing();
Console.WriteLine(ring.ToString());

