using System;

class Player
{
  // Field private = disembunyikan dari luar
  private string nama;
  private int level;
  private int exp;

  // Property dengan validasi
  public string Nama
  {
    get { return nama; }
    set { nama = value.Length > 0 ? value : "Tanpa Nama"; }
  }

  public int Level
  {
    get { return level; }
    set
    {
      if (value < 1) level = 1;
      else if (value > 99) level = 99;
      else level = value;
    }
  }

  public int EXP
  {
    get { return exp; }
    set
    {
      if (value >= 100)
      {
        Level++;
        exp = value - 100; // sisa EXP setelah level up
        System.Console.WriteLine("Level UP! " + Nama + " sekarang Level " + level + "!");
      }
      else exp = value;
    }
  }

  // Contructor
  public Player(string nama, int level, int exp)
  {
    Nama = nama;
    Level = level;
    EXP = exp;
  }

  public void TampilStatus()
  { 
    System.Console.WriteLine(Nama + " | Level: " + level + " | EXP: " + exp + "/100");
  }

  public void TambahEXP(int jumlah)
  {
    System.Console.WriteLine(Nama + " mendapatkan " + jumlah + " EXP!");
    EXP += jumlah;
  }
}

class Senjata
{
  private string nama;
  private int damage;
  private int durabilitas;

  public string Nama
  {
    get { return nama; }
    set { nama = value.Length > 0 ? value : "Tanpa Nama"; }
  }

  public int Damage
  {
    get { return damage; }
    set
    {
      if (value < 1) damage = 1;
      else if (value > 999) damage = 999;
      else damage = value;
    }
  }

  public int Durabilitas
  {
    get { return durabilitas; }
    set { if (value > 0) durabilitas = value;}
  }

  // Contructor
  public Senjata(string nama, int damage, int durabilitas)
  {
    Damage = damage;
    Durabilitas = durabilitas;
    Nama = nama;
  }

  public void TampilStatus()
  { 
    System.Console.WriteLine(Nama + " | Damage: " + damage + " | Durabilitas: " + durabilitas + "/100");
  }

  public void Gunakan()
  {
    if (Durabilitas <= 0)
    {
      System.Console.WriteLine(Nama + " sudah rusak!");
      return;
    }
    Durabilitas -= 10;
    System.Console.WriteLine(Nama + " digunakan!");
    TampilStatus();
  }
}

class Hari9
{
  static void Main()
  {
    System.Console.WriteLine("=== Setup ===");
    Player aksara = new Player("Aksara", 1, 0);
    Senjata excalibur = new Senjata("Excalibur", 50, 100);
    aksara.TampilStatus();
    excalibur.TampilStatus();
    int hpMusuh = 100;
    int hpMusuhMax = 100;
    System.Console.WriteLine("\n=== Pertarungan ===");
    Serang(aksara, excalibur, ref hpMusuh, hpMusuhMax);
    Serang(aksara, excalibur, ref hpMusuh, hpMusuhMax);
  }

  // Method Serang — terima parameter Player, Senjata, dan ref hpMusuh
  static void Serang(Player player, Senjata senjata, ref int hpMusuh, int hpMusuhMax)
  {
    System.Console.WriteLine(player.Nama + " menggunakan " + senjata.Nama + "!");
    senjata.Gunakan(); // kurangi durabilitas
    hpMusuh -= senjata.Damage;
    if (hpMusuh < 0) hpMusuh = 0;
    System.Console.WriteLine("Musuh terkena " + senjata.Damage + " damage! HP Musuh: " + hpMusuh + "/" + hpMusuhMax);

    if (hpMusuh == 0)
    {
      System.Console.WriteLine("Musuh dikalahkan! " + player.Nama + " mendapat 60 EXP!");
      player.TambahEXP(60);
      player.TampilStatus();
    }
  }
}