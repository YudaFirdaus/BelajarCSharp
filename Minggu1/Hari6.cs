using System;
class Hari6
{
  static void Main()
  {
      // INPUT dari pengguna
      System.Console.WriteLine("=== Buat Karakter ===");
      System.Console.WriteLine("Masukkan nama karaktermu: ");
      string nama = Console.ReadLine();

      System.Console.WriteLine("Masukkan kelas (Warrior/Mage/Archer): ");
      string kelas = Console.ReadLine();

      // STRING METHODS
      System.Console.WriteLine("\n=== Info Karakter ===");
      System.Console.WriteLine("Nama: " + nama.ToUpper());
      System.Console.WriteLine("Kelas: " + kelas.ToLower());
      System.Console.WriteLine("Panjang nama: " +nama.Length + " karakter");
      System.Console.WriteLine("Nama dibalik huruf pertama: " +nama.Substring(0, 1).ToUpper() + nama.Substring(1).ToLower());

      // CEK STRING 
      System.Console.WriteLine("\n=== Cek kelas ===");
      if (kelas.ToLower() == "warrior")
          System.Console.WriteLine("Kamu memilih kelas tangguh!");
      else if (kelas.ToLower() == "mage")
        System.Console.WriteLine("Kamu memilih kelas sihir!");
      else if (kelas.ToLower() == "archer")
        System.Console.WriteLine("Kamu memilih kelas jarak jauh!");
      else
        System.Console.WriteLine("Kelas tidak dikenali!");

      // STRING CONTAINS
       System.Console.WriteLine("\n=== Cek nama ===");
       if (nama.Contains("a") || nama.Contains("A"))
           System.Console.WriteLine("Namamu mengandung huruf 'a'!");
       else
           System.Console.WriteLine("Namamu tidak mengandung huruf 'a'.");
        
      // latihan 1
       System.Console.WriteLine("Masukkan nama musuh: ");
       string nama = Console.ReadLine();
       System.Console.WriteLine("=== Data Musuh ===");
       System.Console.WriteLine("Nama asli: " + nama);
       System.Console.WriteLine("Nama kapital: " + nama.ToUpper());
       System.Console.WriteLine("Panjang nama: " + nama.Length + " karakter");
       if (nama.ToLower().Contains("king"))
           System.Console.WriteLine("Mengandung 'king': Ya!");
       else
           System.Console.WriteLine("Mengandung 'king': Tidak!");

      // latihan 2
      System.Console.WriteLine("Masukkan kata sandi: ");
      string sandi = Console.ReadLine();

      System.Console.WriteLine("=== Cek Kata Sandi ===");
      System.Console.WriteLine("Panjang: " + sandi.Length + " karakter");
      if (sandi.Contains("0") || sandi.Contains("1") || sandi.Contains("2") || sandi.Contains("3") || sandi.Contains("4") || sandi.Contains("5") || sandi.Contains("6") || sandi.Contains("7") || sandi.Contains("8") || sandi.Contains("9"))
      {
        System.Console.WriteLine("Mengandung angka: Ya!");
      }
      else
      {
        System.Console.WriteLine("Mengandung angka: Tidak!");
      }
      System.Console.WriteLine("Huruf pertama kapital: " + sandi.Substring(0, 1).ToUpper());
      if (sandi.Length >= 8)
      {
        System.Console.WriteLine("Kata sandi valid!");
      }
      else
      {
        System.Console.WriteLine("Kata sandi tidak valid!");
      }

      // latihan 3
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