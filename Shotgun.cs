using System;
using System.Collections.Generic;

class Shotgun : Weapon
{
    public Shotgun() : base("Shotgun") { }
 
    public override int Damage => 60;
 
    public override void Fire()
    {
        Console.WriteLine("BOOM! Delapan peluru menyebar ke area depan.");
    }
}