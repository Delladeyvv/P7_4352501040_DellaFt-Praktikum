using System;

class Boss : Character, IDamageable, ILootable
{
    private readonly int _maxHealth = 500;
    private bool _isEnraged = false;
 
    public int Health { get; private set; }
 
    public Boss(string name) : base(name)
    {
        Health = _maxHealth;
    }
 
    public override void Attack()
    {
        if (_isEnraged)
            Console.WriteLine($"{Name} mengamuk! Serangan brutal 80 damage.");
        else
            Console.WriteLine($"{Name} menyerang dengan 40 damage.");
    }
 
    public void TakeDamage(int amount)
    {
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} sudah tumbang.");
            return;
        }
 
        Health = Math.Max(0, Health - amount);
        Console.WriteLine($"{Name} menerima {amount} damage. Sisa Health: {Health}/{_maxHealth}");
 
        if (Health == 0)
        {
            Console.WriteLine($"{Name} tumbang!");
            DropLoot();
        }
        else if (!_isEnraged && Health <= _maxHealth / 2)
        {
            _isEnraged = true;
            Console.WriteLine($"{Name} memasuki fase mengamuk!");
        }
    }
 
    public void DropLoot()
    {
        Console.WriteLine($"{Name} menjatuhkan Pedang Legendaris dan 500 emas!");
    }
}