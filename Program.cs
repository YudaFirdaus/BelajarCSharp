using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.WebSockets;
class Hari5
{
    static void Main()
    {
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