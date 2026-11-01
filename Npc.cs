using System;
using System.Collections.Generic;

class Npc : IInteractable
{
    public string Name { get; }
 
    public Npc(string name)
    {
        Name = name;
    }
 
    public string Prompt => $"Tekan E untuk berbicara dengan {Name}";
 
    public void Interact()
    {
        Console.WriteLine($"{Name}: \"Selamat datang, petualang! Hati-hati di hutan sebelah utara.\"");
    }
}