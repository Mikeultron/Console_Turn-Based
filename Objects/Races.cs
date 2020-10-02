public abstract class Races : Player{
  private string race;
  private string basic;
  private string super;
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
  public abstract void CastSuperSkill();
  public abstract void CastBasicSkill();
  public abstract void Hit(int damage);
}