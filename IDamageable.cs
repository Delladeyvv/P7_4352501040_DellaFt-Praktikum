using System;

interface IDamageable
{
    int Health { get; }
    void TakeDamage(int amount);
}