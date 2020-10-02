using System;

public class Human : Races{
  public string Name { get; set; }
  public Human(string name){
    this.Name = name;
    this.Damage = 100;
    this.Health = 1000;
    this.Race = "Human";
    this.Basic = "Slash";
    this.Super = "Divine Slash";
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