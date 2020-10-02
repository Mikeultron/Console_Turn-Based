// We create Races class to set each race's skill. Both races has 2 skills which is basic and super skill.
// We use abstract so that we can do Polymorphism.
// We also do Abstraction here.
public abstract class Races : Player{
  // We use private access modifier so that other classes can't directly read and write values.
  private string race;
  private string basic;
  private string super;

  // We use protected access modifier so that only derived class can read and write the value from this properties.
  protected string Race {
    get{return race;}
    set{race = value;}
  }
  protected string Basic {
    get{return basic;}
    set{basic = value;}
  }
  protected string Super {
    get{return super;}
    set{super = value;}
  }

  // We use abstract keyword to let the derived class override it and have their own implementation.
  public abstract void CastSuperSkill();
  public abstract void CastBasicSkill();
  public abstract void Hit(int damage);
}