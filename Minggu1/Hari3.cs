using System;

class Hari3
{
    static void MainHari3()
    {
        // FOR LOOP - spawn musuh 5 kali
        Console.WriteLine("=== Spawn Musuh ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Musuh " + i + " muncul!");
        }

        // WHILE LOOP - karakter menyerang sampai musuh mati
        Console.WriteLine("\n=== Pertarungan ===");
        int hpMusuh = 100;
        int damage = 25;
        int giliran = 1;

        while (hpMusuh > 0)
        {
            hpMusuh -= damage;
            Console.WriteLine("Giliran " + giliran + ": Serang! HP Musuh: " + hpMusuh);
            giliran++;
        }
        Console.WriteLine("Musuh telah dikalahkan!");

        // DO WHILE - minimal sekali tampil menu
        Console.WriteLine("\n=== Status Player ===");
        int nyawa = 3;
        do
        {
            Console.WriteLine("Nyawa tersisa: " + nyawa);
            nyawa--;
        } while (nyawa > 0);
        Console.WriteLine("Game Over!");

        // NESTED LOOP - dungeon dengan loop di dalam loop
        Console.WriteLine("\n=== Dungeon ===");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Lantai " + i + ": Masuk...");
            int HP = 60;
            while (HP > 0)
            {
                HP -= 20;
                Console.WriteLine("Musuh muncul! HP Musuh: " + HP);
            }
            Console.WriteLine("Lantai " + i + " selesai!\n");
        }
        Console.WriteLine("Dungeon selesai!");
    }
}