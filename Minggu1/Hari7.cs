using System;

class Hari7
{
  static void Main()
  {
    System.Console.WriteLine("=== GAME RPG SEDERHANA ===");
    System.Console.WriteLine("Masukkan nama karaktermu: ");
    string nama = Console.ReadLine();
    System.Console.WriteLine("Pilih kelas (Warrior/Mage/Archer): ");
    string kelas = Console.ReadLine();

    int hp = 0;
    int attack = 0;
    string[] skill = {};

    if (kelas.ToLower() == "warrior")
    {
      hp = 100;
      attack = 30;
      skill = new string [] {"Slash", "Shild Bash", "War Cry"};
    }
    else if (kelas.ToLower() == "mage")
    {
      hp = 70;
      attack = 50;
      skill = new string [] {"Fireball", "Ice Spike", "Thunder"};
    }
    else if (kelas.ToLower() == "archer")
    {
      hp = 85;
      attack = 45;
      skill = new string [] {"Arrow Shot", "Multi Shot", "Eagele Eye"};
    }

    System.Console.WriteLine("\n=== Karakter Dibuat! ===");
    System.Console.WriteLine("Nama: " + nama);
    System.Console.WriteLine("Kelas: " + kelas);
    System.Console.WriteLine("HP: " + hp);
    System.Console.WriteLine("Attack: " + attack);

    System.Console.WriteLine("\n=== Skill " + kelas + " ===");
    for (int i = 0; i < skill.Length; i++)
    {
      System.Console.WriteLine((i + 1) + ". " + skill[i]);
    }

    System.Console.WriteLine("\n=== Simulasi Pertarungan ===");
    System.Console.WriteLine(nama + " menyerang musuh!");
    int HPmusuh = 100;
    int giliran = 1;
    while (HPmusuh > 0)
    {
      HPmusuh -= attack;
      if (HPmusuh < 0) HPmusuh = 0;
      System.Console.WriteLine("Giliran " + giliran + " - Hp Musuh: " + HPmusuh);
      giliran++;
    }
    System.Console.WriteLine("Musuh dikalahkan dalam " + (giliran -1) + " giliran!");
  }
}