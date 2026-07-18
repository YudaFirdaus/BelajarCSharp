using System;
using System.Runtime;

// CLASS INDUK
class Karakter
{
  public string Nama { get; set; }
  public int HP { get; set; }
  public int Attack { get; set; }

  public Karakter(string nama, int hp, int attack)
  {
    Nama = nama;
    HP = hp;
    Attack = attack;
  }

  public void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Attack: " + Attack );
  }

  public virtual void Serang(Karakter target)
  {
    target.HP -= Attack;
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(Nama + " menyerang " + target.Nama + "! Damage: " + Attack);
    System.Console.WriteLine(target.Nama + " Hp tersisa: " + target.HP);
  }
}

// CLASS ANAK - Player
class Player : Karakter
{
  public int Level { get; set; }

  public Player(string nama, int hp, int attack, int level)
      : base(nama, hp, attack) // panggil constructor induk
  {
    Level = level;
  }

  public override void Serang(Karakter target)
  {
    int bonusDamage = Level * 5;
    target.HP -= Attack + bonusDamage;
    System.Console.WriteLine(Nama + " (Level " + Level + ") menyerang " + target.Nama + "! Damage: " + (Attack + bonusDamage));
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
    if (target.HP <= 0) 
    System.Console.WriteLine(target.Nama + " dikalahkan!");
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Attack: " + Attack + " | Level: " + Level);
  }
}

class Mage : Karakter
{
  public int Mana { get; set; }

  public Mage(string nama, int hp, int attack, int mana)
      : base(nama, hp, attack)
  {
    Mana = mana;
  }

  public override void Serang(Karakter target)
  {
    if (Mana >= 20)
    {
      int bonusDamage = Mana / 10;
      target.HP -= Attack + bonusDamage;
      Mana -= 20;
      System.Console.WriteLine(Nama + " mengeluarkan sihir! Damage: " + (Attack + bonusDamage) + " (Mana tersisa: " + Mana + ")");
      if (target.HP < 0) target.HP = 0;
      System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
      if (target.HP <= 0) System.Console.WriteLine(target.Nama + " dikalahkan!");
    }
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Attack: " + Attack + " | Mana: " + Mana);
  }
}

class Archer : Karakter
{
  public int Arrows { get; set; }

  public Archer(string nama, int hp, int attack, int arrows)
      : base(nama, hp, attack)
  {
    Arrows = arrows;
  }

  public override void Serang(Karakter target)
  {
    if (Arrows > 0)
    {
      int bonusDamage = 10;
      target.HP -= Attack + bonusDamage;
      Arrows -= 1;
      System.Console.WriteLine(Nama + " menembak panah! Damage: " + (Attack + bonusDamage) + " (Arrows tersisa: " + Arrows + ")");
      if (target.HP < 0) target.HP = 0;
      System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
      if (target.HP <= 0) System.Console.WriteLine(target.Nama + " dikalahkan!");
    }
    else
    {
      System.Console.WriteLine("Panah habis! " + Nama + " tidak bisa menyerang!");
    }
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Attack: " + Attack + " | Arrows: " + Arrows);
  }
}

class Enemy : Karakter
{
  public string Tipe { get; set; }

  public Enemy(string nama, int hp, int attack, string tipe)
      : base(nama, hp, attack)
  {
    Tipe = tipe;
  }

  public override void Serang(Karakter target)
  {
    System.Console.WriteLine("[" + Tipe + "] " + Nama + " menyerang!");
    base.Serang(target); // panggil method induk
  }
}

class Hari10
{
  static void Main()
  {
    Player aksara = new Player("Aksara", 100, 30, 5);
    Mage shina = new Mage("Shina", 80, 20, 100);
    Archer raka = new Archer("Raka", 90, 25, 5);

    System.Console.WriteLine("=== Tim Pahlawan ===");
    aksara.TampilStatus();
    shina.TampilStatus();
    raka.TampilStatus();

    Enemy goblin = new Enemy("Goblin", 60, 15, "Monster");
    Enemy darkLord = new Enemy("Dark Lord", 150, 40, "Boss");

    System.Console.WriteLine("\n=== Musuh ===");
    goblin.TampilStatus();
    darkLord.TampilStatus();

    System.Console.WriteLine("\n=== Ronde 1 ===");
    aksara.Serang(goblin);
    shina.Serang(goblin);
    raka.Serang(darkLord);

    System.Console.WriteLine("\n=== Ronde 2 ===");
    aksara.Serang(darkLord);
    shina.Serang(darkLord);
    raka.Serang(darkLord);
  }
}