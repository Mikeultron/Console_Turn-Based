using System;

// Orc explanation is same as Human explanation
public class Orc : Races{
  public string Name { get; set; }
  public Orc(string name){
    this.Name = name;
    this.Damage = 150;
    this.Health = 800;
    this.Race = "Orc";
    this.Basic = "Chop";
    this.Super = "Mega Chop";
  }

  public override void CastSuperSkill() => Console.WriteLine($"{this.Name} cast {this.Super} and dealt {this.Damage * 2} damage\n");

  public override void CastBasicSkill() => Console.WriteLine($"{this.Name} cast {this.Basic} and dealt {this.Damage} damage\n");

  public override void Hit(int damage)
  {
    Console.WriteLine($"{this.Name} get hit and suffer {damage} damage\n");
    this.Health -= damage;
    Console.WriteLine($"{this.Name}'s health left is {this.Health}");
  }
}