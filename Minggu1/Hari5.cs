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

    }
}