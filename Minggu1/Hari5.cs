using System;
using System.Collections.Generic;
class Hari5
{
    static void Main()
    {
        // ARRAY - ukuran tetap
        System.Console.WriteLine("=== Inventory (Array) ===");
        string[] inventory = {"Pedang", "Perisai", "Ramuan", "Busur", "Panah"};
        for (int i = 0; i < inventory.Length; i++)
        {
            System.Console.WriteLine("Slot " + (i + 1) + ": " + inventory[i]);
        }

        // Akses langsung by index
        System.Console.WriteLine("Item di slot 3: " + inventory[2]);
        
        // Ganti item
        inventory[2] = "Ramuan Besar";
        System.Console.WriteLine("Slot 3 diganti: " + inventory[2]);

        // LIST - ukuran fleksibel
        System.Console.WriteLine("\n=== Daftar Musuh (list) ===");
        List<string> musuh = new List<string>();

        // Tambah musuh
        musuh.Add("Goblin");
        musuh.Add("Orc");
        musuh.Add("Dragon");

        System.Console.WriteLine("Musuh saat ini: " + musuh.Count);
        foreach (string m in musuh)
        {
            System.Console.WriteLine("- " + m);
        }

        // Hapus musuh
        musuh.Remove("Orc");
        System.Console.WriteLine("\nSetelah Orc dikalahkan: " + musuh.Count + " musuh");
        foreach (string m in musuh)
        {
            System.Console.WriteLine("- " + m);
        }

        // latihan 1
        System.Console.WriteLine("\n=== Tim Pahlawan ===");
        string[] daftar_pahlawan = {"Warrior", "Mage", "Archer", "Healer", "Rogue"};
        for (int i = 0; i < daftar_pahlawan.Length; i++)
        {
            System.Console.WriteLine("Pahlawan " + (i + 1) + ": " + daftar_pahlawan[i]);
        }
        System.Console.WriteLine("Jumlah pahlawan: " + daftar_pahlawan.Length);
        System.Console.WriteLine("Pemimpin tim: " + daftar_pahlawan[0]);
        // latihan 2
         System.Console.WriteLine("=== Toko Item ===");
        List<string> item = new List<string> { "Health Potion", "Mana Potion", "Elixir" };
        System.Console.WriteLine("Item tersedia: " + item.Count);
        foreach (string i in item)
        {
            System.Console.WriteLine("- " + i);
        }

        System.Console.WriteLine("\n=== Beli item ===");
        // tambah item baru
        item.Add("Mega potion");
        item.Add("Revival Stone");
        System.Console.WriteLine("Membeli: " + item[3]);
        System.Console.WriteLine("Membeli: " + item[4]);
        System.Console.WriteLine("Item tersedia: " + item.Count);
        foreach (string i in item)
        {
            System.Console.WriteLine("- " + i);
        }

        System.Console.WriteLine("\n=== Hapus item ===");
        System.Console.WriteLine("Menjual: " + item[1]);
        // jual item
        item.Remove("Mana Potion");
        System.Console.WriteLine("Item tersedia: " + item.Count);
        foreach (string i in item)
        {
            System.Console.WriteLine("- " + i);
        }
        // latihan 3
           System.Console.WriteLine("=== Skill Karakter ===");
        List<string> skill = new List<string> { "Slash", "Shield Bash", "War Cry"};
        foreach (string s in skill)
        {
            System.Console.WriteLine("- " + s);
        }

        System.Console.WriteLine("\n=== Belajar Skill Baru ===");
        skill.Add("Counter Attack");
        skill.Add("Berserker Mode");
        System.Console.WriteLine("Warrior mempelajari: " + skill[3]);
        System.Console.WriteLine("Warrior mempelajari: " + skill[4]);
        System.Console.WriteLine("Warrior kini memiliki " + skill.Count + " skill!");

        System.Console.WriteLine("\n=== Lupa Skill ===");
        System.Console.WriteLine("Warrior melupakan: " + skill[1]);
        skill.Remove("Shield Bash");
        System.Console.WriteLine("Skill aktif Warrior: " + skill.Count);
        foreach (string s in skill)
        {
            System.Console.WriteLine("- " + s);
        }

        System.Console.WriteLine("\n=== Skill Utama ===");
        System.Console.WriteLine("Skill pertama: " + skill[0]);
        System.Console.WriteLine("Skill terakhir: " + skill[skill.Count - 1]);

    }
}