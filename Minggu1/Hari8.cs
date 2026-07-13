using System;

// CLASS - blueprint karakter
class Karakter
{
  // PROPERTIES - data yang dimiliki karakter
  public string Nama;
  public string Kelas;
  public int HP;
  public int Attack;

  // CONSTRUCTOR - dijalankan saat object dibuat
  public Karakter(string nama, string kelas, int hp, int attack)
  {
    Nama = nama;
    Kelas = kelas;
    HP = hp;
    Attack = attack;
  }

  // METHODS - aksi yang bisa dilakukan karakter
  public void TampilanInfo()
  {
    System.Console.WriteLine("=== " + Nama + " ===");
    System.Console.WriteLine("Kelas: " + Kelas);
    System.Console.WriteLine("HP: " + HP);
    System.Console.WriteLine("Attack: " + Attack);
  }

  public void Serang(Karakter target)
  {
    int damage = Attack - 5;
    if (damage < 0) damage = 0;
    target.HP -= damage;
    System.Console.WriteLine(Nama + " menyerang " + target.Nama + "! Damage: " + damage);
    System.Console.WriteLine(target.Nama + " HP tersisa: " + target.HP);
  }
}
  class Senjata // contoh 1 dan 2
{
  // PROPERTIES - data yang dimiliki karakter
  public string Nama;
  public int Damage;
  public string Tipe;

  // CONSTRUCTOR - dijalankan saat object dibuat
  public Senjata(string nama, int damage, string tipe)
  {
    Nama = nama;
    Damage = damage;
    Tipe = tipe;
  }

  // METHODS - spesifikasi senjata
  public void TampilanInfo()
  {
    System.Console.WriteLine("=== Senjata ===");
    System.Console.WriteLine("Nama: " + Nama);
    System.Console.WriteLine("Damage: " + Damage);
    System.Console.WriteLine("Tipe: " + Tipe);
  }

  public void Bandingkan(Senjata lain)
  {
    System.Console.WriteLine("=== Perbandingan Senjata ===");
    System.Console.WriteLine(Nama + " (" +Damage + ") " + "vs " + lain.Nama + " (" + lain.Damage + ") ");
    if (Damage > lain.Damage)
    {
      System.Console.WriteLine(Nama + " Lebih kuat!");
    }
    else if (Damage == lain.Damage)
    {
      System.Console.WriteLine("Sama kuat !");
    }
    else
    {
      System.Console.WriteLine(lain.Nama + " Lebih kuat!");
    }
  }
}

class Inventory
{
  public string PemilikNama;
  public List<Senjata> DaftarSenjata;

  public Inventory(string nama)
  {
    PemilikNama = nama;
    DaftarSenjata = new List<Senjata>();
  }

  public void TambahSenjata(Senjata s)
  {
    DaftarSenjata.Add(s);
    System.Console.WriteLine(s.Nama + " ditambahkan ke inventory!");
  }

  public void HapusSenjata(string namaSenjata)
  {
    for (int i = 0; i < DaftarSenjata.Count; i++)
    {
      if (DaftarSenjata[i].Nama == namaSenjata)
      {
        DaftarSenjata.RemoveAt(i);
        System.Console.WriteLine(namaSenjata + " dihapus dari inventory!");
        return;
      }
    }
  }

  public void TampilInventory()
  {
    System.Console.WriteLine("=== Inventory " + PemilikNama + " ===");
    for (int i = 0; i < DaftarSenjata.Count; i++)
    {
      System.Console.WriteLine("Slot " + (i + 1) + ": " + DaftarSenjata[i].Nama + " (Damage: " + DaftarSenjata[i].Damage + ")");
    }
    System.Console.WriteLine("Total senjata: " + DaftarSenjata.Count);
  }
}

class Hari8
{
  static void Main()
  {
    // Buat OBJECT dari class Karakter
    Karakter aksara = new Karakter("Aksara", "Warrior", 100, 30);
    Karakter musuh = new Karakter("Goblin", "Monster", 50, 15);

    // Tampilkan info
    aksara.TampilanInfo();
    System.Console.WriteLine();
    musuh.TampilanInfo();

    // Simulasi Pertarungan
    System.Console.WriteLine("\n=== Pertarungan ===");
    aksara.Serang(musuh);
    musuh.Serang(aksara);
    aksara.Serang(musuh);

    // Buat OBJECT dari class Senjata
    Senjata excalibur = new Senjata("Excalibur", 50, "Pedang");
    Senjata sword = new Senjata("Sword", 55, "Pedang");
    Senjata staff = new Senjata("Staff", 45, "Tongkat");
    Senjata dagger = new Senjata("Dagger", 30, "Pisau");

    Inventory inv = new Inventory("Aksara");
    inv.TambahSenjata(excalibur);
    inv.TambahSenjata(sword);
    inv.TambahSenjata(staff);
    inv.TampilInventory();

    // Tambah dagger
    System.Console.WriteLine("\n=== Tambah Senjata ===");
    inv.TambahSenjata(dagger);
    System.Console.WriteLine("Total senjata: " + inv.DaftarSenjata.Count);

    // Hapus sword
    System.Console.WriteLine("\n=== Hapus Senjata ===");
    inv.HapusSenjata("Sword");
    System.Console.WriteLine("Total senjata: " + inv.DaftarSenjata.Count);

    // Tampil inventory akhir
    System.Console.WriteLine("\n=== Inventory Akhir ===");
    inv.TampilInventory();

    // Tampilkan info
    excalibur.TampilanInfo();
    System.Console.WriteLine();
    sword.TampilanInfo();
    System.Console.WriteLine();
    staff.TampilanInfo();
    System.Console.WriteLine();

    // Tampilkan perbandingan senjata
    excalibur.Bandingkan(sword);
    System.Console.WriteLine();
    excalibur.Bandingkan(staff);
    System.Console.WriteLine();
    sword.Bandingkan(staff);
  }
}