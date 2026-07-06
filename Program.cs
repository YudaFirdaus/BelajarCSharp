using System;

class Hari6
{
  static void Main()
  {
   System.Console.WriteLine("Masukkan kalimat: ");
   string kalimat = Console.ReadLine();
   System.Console.WriteLine("=== Analisis Kalimat ===");
   System.Console.WriteLine("Kalimat asli: " + kalimat);
   System.Console.WriteLine("Huruf kapital semua: " + kalimat.ToUpper());
   System.Console.WriteLine("Panjang kalimat: " + kalimat.Length + " karakter");
   if (kalimat.Contains("musuh") || kalimat.Contains("Musuh"))
    {
      System.Console.WriteLine("Mengandung kata 'musuh': Ya!");
    }
    else
    {
      System.Console.WriteLine("Mengandung kata 'musuh': Tidak!");
    }
    System.Console.WriteLine("Huruf pertama kapital: " + kalimat.Substring(0, 1).ToUpper() + kalimat.Substring(1));
  }
}