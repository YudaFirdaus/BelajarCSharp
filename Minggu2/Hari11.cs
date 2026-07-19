using System;

// interface
interface IBisa
{
  void GunakanSkill();
  string NamaSkill { get; }
}

interface IBisaSembuh
{
  void Sembuhkan(KarakterBase target);
  int HealPower { get; }
}

interface IBisaBertahan
{
  void Bertahan();
  int DefensePower { get;}
}

// ABSTRACT CLASS
abstract class KarakterBase
{
  public string Nama { get; set; }
  public int HP { get; set; }

  public KarakterBase(string nama, int hp)
  {
    Nama = nama;
    HP = hp;
  }

  // Method abstact - WAJIB diimplementasikan di class anak
  public abstract void Serang(KarakterBase target);

  // method biasa - bisa dipakai langsung
  public void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP);
  }
}

// CLASS yang pakai abstract class DAN interface
class Warrior : KarakterBase, IBisa
{
  public int Shield { get; set; }
  public string NamaSkill { get; } = "Shield Bash";

  public Warrior(string nama, int hp, int shield)
      : base(nama, hp)
  {
    Shield = shield;
  }

  public override void Serang(KarakterBase target)
  {
    int damage = 30;
    target.HP -= damage;
    System.Console.WriteLine(Nama + " menyerang! Damage: " + damage);
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
    if (target.HP <=0) System.Console.WriteLine(target.Nama + " dikalahkan!");
  }

  public void GunakanSkill()
  {
    System.Console.WriteLine(Nama + " menggunakan " + NamaSkill + "! Shield: " + Shield);
    Shield += 10;
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Shield: " + Shield);
  }
}

class Rogue : KarakterBase, IBisa
{
  public string NamaSkill { get; } = "Backstab";

  public Rogue(string nama, int hp)
      : base(nama, hp) { }

  public override void Serang(KarakterBase target)
  {
    int damage = 45;
    target.HP -= damage;
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(Nama + " menyerang dari belakang! Damage: " + damage);
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
    if (target.HP <= 0) System.Console.WriteLine(target.Nama + " dikalahkan!");
  }

  public void GunakanSkill()
  {
    System.Console.WriteLine(Nama + " menggunakan " + NamaSkill + "! Damage x2 untuk serangan berikutnya!");
  }
}

class Healer : KarakterBase, IBisa, IBisaSembuh
{
  public string NamaSkill { get; } = "Holy Light";
  public int HealPower { get; set; }

  public Healer(string nama, int hp, int healpower)
      : base(nama, hp) 
  {
    HealPower = healpower;
  }

  public override void Serang(KarakterBase target)
  {
    int damage = 15;
    target.HP -= damage;
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(Nama + " menyerang! Damage: " + damage);
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
    if (target.HP <= 0) System.Console.WriteLine(target.Nama + " dikalahkan!");
  }

  public void Sembuhkan(KarakterBase target)
  {
    int hpSebelum = target.HP;
    target.HP += HealPower;
    if (target.HP > 1000) target.HP = 1000;
    System.Console.WriteLine(Nama + " menyembuhkan " + target.Nama + "! HP " + target.Nama + ": " + hpSebelum + " -> " + (hpSebelum + HealPower));
  }

  public void GunakanSkill()
  {
    System.Console.WriteLine(Nama + " menggunakan " + NamaSkill + "! Heal Power: " + HealPower);
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Heal Power: " + HealPower);
  }
}

class Knight : KarakterBase, IBisa, IBisaSembuh, IBisaBertahan
{
  public string NamaSkill { get; } = "Holy Sword";
  public int HealPower { get; set; }
  public int DefensePower { get; set; }

  public Knight(string nama, int hp, int defensepower, int healpower)
      : base(nama, hp)
  {
    HealPower = healpower;
    DefensePower = defensepower;
  }

  public override void Serang(KarakterBase target)
  {
    int damage = 40;
    target.HP -= damage;
    if (target.HP <0) target.HP = 0;
    System.Console.WriteLine(Nama + " menyerang! Damage: " + damage);
    if (target.HP < 0) target.HP = 0;
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
    if (target.HP <= 0) System.Console.WriteLine(target.Nama + " dikalahkan!");
  }

  public void Bertahan()
  {
    System.Console.WriteLine(Nama + " bertahan! Defense power: " + DefensePower + " - Damage berkurang 50%!");
  }

  public void Sembuhkan(KarakterBase target)
  {
    int hpSebelum = target.HP;
    target.HP += HealPower;
    if (target.HP > 1000) target.HP = 1000;
    System.Console.WriteLine(Nama + " menyembuhkan diri sendiri! HP " + target.Nama + ": " + hpSebelum + " -> " + (hpSebelum + HealPower));
  }


  public void GunakanSkill()
  {
    System.Console.WriteLine(Nama + " menggunakan " + NamaSkill + "! Heal Power: " + HealPower + " | Defense Power: " + DefensePower);
  }

  public new void TampilStatus()
  {
    System.Console.WriteLine(Nama + " | HP: " + HP + " | Shield: " + DefensePower + " | Heald: " + DefensePower + " | Heal Power: " + HealPower);
  }
}

class Hari11
{
  static void Main()
  {
    System.Console.WriteLine("=== Tim Pahlawan ===");
    Warrior thor = new Warrior("Thor", 120, 50);
    Rogue shadow = new Rogue("Shadow", 80);
    Healer elena = new Healer("Elena", 70, 30);
    Knight arthur = new Knight("Arthur", 150, 80, 20);

    thor.TampilStatus();
    shadow.TampilStatus();
    elena.TampilStatus();
    arthur.TampilStatus();

    System.Console.WriteLine("\n=== Musuh ===");
    Rogue orc = new Rogue("Orc", 100);
    Rogue dragon = new Rogue("Dragon", 200);

    orc.TampilStatus();
    dragon.TampilStatus();

    System.Console.WriteLine("\n=== Serangan ===");
    thor.Serang(orc);
    shadow.Serang(orc);
    elena.GunakanSkill();
    elena.Serang(orc);
    arthur.Serang(orc);

    System.Console.WriteLine("\n=== Ronde 2 ===");
    thor.Serang(dragon);
    shadow.Serang(dragon);
    elena.Serang(dragon);
    arthur.Serang(dragon);

    System.Console.WriteLine("\n=== Ronde 3 ===");
    thor.Serang(dragon);
    arthur.Serang(dragon);
  }
}