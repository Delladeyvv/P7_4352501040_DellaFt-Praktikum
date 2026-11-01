using System;
using System.Collections.Generic;

class Pistol : Weapon
{
    public Pistol() : base("Pistol") { }
 
    public override int Damage => 15;
 
    public override void Fire()
    {
        Console.WriteLine("Dor! Satu peluru ditembakkan dengan cepat.");
    }
}