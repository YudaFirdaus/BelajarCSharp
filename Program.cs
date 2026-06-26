using System;

class Hari3
{
    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            System.Console.WriteLine("Lantai " + i + ": Masuk...");
            int HP = 60;
            while (HP > 0)
            {
                HP -= 20;
                System.Console.WriteLine("Musuh muncul! HP Musuh: " + HP);
            }
             System.Console.WriteLine("Lantai " + i + " selesai!\n");
        }
        System.Console.WriteLine("Dungeon selesai!");
    }
     
    
}