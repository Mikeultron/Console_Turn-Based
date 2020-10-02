// We create Player class to inherit it to the Race class, so that each race has the same functionality and we can freely modify each race's stats.
public class Player{
  private int health;
  private int damage;
  public int Health {
    get{return health;}
    set{health = value;}
  }
  public int Damage{
    get{return damage;}
    set{damage = value;}
  }
}