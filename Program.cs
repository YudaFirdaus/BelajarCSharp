using System;

class Hari4
{
    // Fungsi dengan return string
    static string CekHP(int hp)
    {
        if (hp > 60) return "Sehat";
        else if (hp > 30) return "Terluka";
        else return "Kritis";
    }

    static void Main()
    {
        // Panggil fungsi CekHp
        System.Console.WriteLine("Hp 75: " + CekHP(75));
        System.Console.WriteLine("HP 35: " + CekHP(35));
        System.Console.WriteLine("HP 10: " + CekHP(10));
    }
}