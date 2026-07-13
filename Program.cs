using System;
using System.Collections.Generic;

 class Senjata
{
  public string Nama;
  public int Damage;
  public string Tipe;

  public Senjata(string nama, int damage, string tipe)
  {
    Nama = nama;
    Damage = damage;
    Tipe = tipe;
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
  }
}