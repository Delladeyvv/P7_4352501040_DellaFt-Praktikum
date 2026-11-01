using System;
using System.Collections.Generic;

abstract class Weapon
{
    public string Name { get; }                
    public abstract int Damage { get; }        
 
    protected Weapon(string name)
    {
        Name = name;
    }
 
    public abstract void Fire();               
 
    public void Reload()                       
    {
        Console.WriteLine($"{Name} di-reload. Siap menembak lagi.");
    }
}