using System;

class Hari4
{
    // Fungsi tanpa return value
    static void SapaPlayer (string nama)
    {
        System.Console.WriteLine("Selamat datang, " + nama + "!");
    }
     
    // Fungsi degan return value
    static int HitungDamage(int attack, int defense)
    {
        int damage = attack - defense;
        if (damage < 0) damage = 0;
        return damage;
    }

    // Fungsi dengan return string
    static string CekRank(int level)
    {
        if (level >= 10) return "Veteran";
        else if (level >= 5) return "Pejuang";
        else return "Pemula";
    }

    // Fungsi dengan return string
    static string CekHP(int hp)
    {
        if (hp > 60) return "Sehat";
        else if (hp > 30) return "Terluka";
        else return "Kritis";
    }

    static void Main()
    {
        // Panggil fungsi SapaPlayer
        SapaPlayer("Yuda");
        SapaPlayer("Aksara");

        // Panggil fungsi HitungDamage
        int damage = HitungDamage(50, 20);
        System.Console.WriteLine("Damage yang diterima: " + damage);

        int damage2 = HitungDamage(10, 30);
        System.Console.WriteLine("Damage yang diterima: " + damage2);

        // Panggil fungsi Cekrank
        System.Console.WriteLine("Rank level 3: " + CekRank(3));
        System.Console.WriteLine("Rank level 7: " + CekRank(7));
        System.Console.WriteLine("Rank level 12: " + CekRank(12));

         // Panggil fungsi CekHp
        System.Console.WriteLine("Hp 75: " + CekHP(75));
        System.Console.WriteLine("HP 35: " + CekHP(35));
        System.Console.WriteLine("HP 10: " + CekHP(10));

    }
}