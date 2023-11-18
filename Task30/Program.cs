using System;

public interface IGameCharacter
{
    void Attack();
    void Defend();
}

public class Warrior : IGameCharacter
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword!");
    }

    public void Defend()
    {
        Console.WriteLine("Warrior raises a shield to defend!");
    }
}

public class Mage : IGameCharacter
{
    public void Attack()
    {
        Console.WriteLine("Mage casts a fireball!");
    }

    public void Defend()
    {
        Console.WriteLine("Mage creates a magical barrier for defense!");
    }
}

public class Archer : IGameCharacter
{
    public void Attack()
    {
        Console.WriteLine("Archer shoots an arrow!");
    }

    public void Defend()
    {
        Console.WriteLine("Archer dodges attacks with agility!");
    }
}

class Program
{
    static void Main()
    {
        IGameCharacter warrior = new Warrior();
        IGameCharacter mage = new Mage();
        IGameCharacter archer = new Archer();

        PerformActions(warrior);
        PerformActions(mage);
        PerformActions(archer);

    }

    static void PerformActions(IGameCharacter character)
    {
        Console.WriteLine($"Character Type: {character.GetType().Name}");
        character.Attack();
        character.Defend();
        Console.WriteLine();
    }
}