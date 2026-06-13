using System;

class Hari2
{
    static void MainHari2()
    {
        int hp = 75;
        int hpMaksimal = 100;
        int level = 5;
        string nama = "Yuda";

        // Cek kondisi HP
        if (hp <= 0)
        {
            Console.WriteLine(nama + " telah gugur! Game Over.");
        }
        else if (hp < 30)
        {
            Console.WriteLine("Peringatan! HP " + nama + " kritis: " + hp);
        }
        else if (hp < 60)
        {
            Console.WriteLine(nama + " terluka. HP: " + hp);
        }
        else
        {
            Console.WriteLine(nama + " sehat. HP: " + hp + "/" + hpMaksimal);
        }

        // Cek level
        if (level >= 10)
        {
            Console.WriteLine("Rank: Veteran");
        }
        else if (level >= 5)
        {
            Console.WriteLine("Rank: Pejuang");
        }
        else
        {
            Console.WriteLine("Rank: Pemula");
        }
    }
}