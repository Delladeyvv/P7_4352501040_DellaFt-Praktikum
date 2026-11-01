using System;

abstract class Character
{
    public string Name { get; }
 
    protected Character(string name)
    {
        Name = name;
    }
 
    public abstract void Attack();
}