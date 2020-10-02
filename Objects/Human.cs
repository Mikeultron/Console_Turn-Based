using System;

// See that Human derived from Races so that we can finally implement our Human class.
// Since Races derived from player, now Human can have both Player and Races code.
public class Human : Races{

  // We create property name for giving this Human name.
  public string Name { get; set; }

  // We use constructor to initialize this Human stats, skills and name.
  public Human(string name){
    this.Name = name;
    this.Damage = 100;
    this.Health = 1000;
    this.Race = "Human";
    this.Basic = "Slash";
    this.Super = "Divine Slash";
  }
  
  // Don't mind the syntax. We use override keyword to override the method that uses abstract keyword in the Races class.
  // We use string interpolation to make it easier for writing strings.
  public override void CastSuperSkill() => Console.WriteLine($"{this.Name} cast {this.Super} and dealt {this.Damage * 2} damage\n");
  public override void CastBasicSkill() => Console.WriteLine($"{this.Name} cast {this.Basic} and dealt {this.Damage} damage\n");

  // This method will reduce Human's health based on the parameter.
  public override void Hit(int damage)
  {
    Console.WriteLine($"{this.Name} get hit and suffer {damage} damage\n");
    this.Health -= damage;
    Console.WriteLine($"{this.Name}'s health left is {this.Health}");
  }
}