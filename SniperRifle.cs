using System;
using System.Collections.Generic;

class SniperRifle : Weapon
{
    public SniperRifle() : base("Sniper Rifle") { }
 
    public override int Damage => 120;
 
    public override void Fire()
    {
        Console.WriteLine("Membidik lewat scope... DOR! Satu tembakan presisi jarak jauh.");
    }
}