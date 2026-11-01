using System;

Boss boss = new Boss("Draegor");
 
Console.WriteLine(" Boss menyerang ");
boss.Attack();
 
List<IDamageable> targets = new() { boss };
 
Console.WriteLine("\n Serangan area 150 damage, empat kali ");
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"\nSerangan ke-{i}:");
    foreach (IDamageable t in targets)
        t.TakeDamage(150);
}
 
Console.WriteLine("\n Boss menyerang setelah mengamuk ");
boss.Attack();