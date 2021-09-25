using System;

namespace Dasar_Pemrograman
{
    class Program
    {
        static void Pembukaan(int level)
        {
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Mulai level " + level);
        }

        static bool MulaiMain(int level)
        {
            Pembukaan(level);

            // Inisialisasi dan Deklarasi variabel
            // Menggunakan Random class untuk mengacak nilai variabel
            Random rng = new Random();
            int codeA = rng.Next(level);
            int codeB = rng.Next(level);
            int codeC = rng.Next(level);

            int hasilTambah = codeA + codeB + codeC;
            int hasilKali = codeA * codeB * codeC;

            Console.WriteLine("- Password terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya " + hasilKali);
            Console.WriteLine("");
            
            // User input
            Console.Write("Enter Code A: ");
            string tebakanA = Console.ReadLine();
            Console.Write("Enter Code B: ");
            string tebakanB = Console.ReadLine();
            Console.Write("Enter Code C: ");
            string tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda " + tebakanA + " " + tebakanB + " " + tebakanC + " ?");
            
            // Convert user input (string) to (int)
            int tebakA = Convert.ToInt32(tebakanA);
            int tebakB = Convert.ToInt32(tebakanB);
            int tebakC = Convert.ToInt32(tebakanC);
            
            if (tebakA == codeA && tebakB == codeB && tebakC == codeC)
            {
                Console.WriteLine("Tebakan anda benar");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("Tebakan anda salah. Coba lagi");
                Console.WriteLine("");
                return false;
            }
        }

        static void Main(string[] args)
        {
            int level = 1;
            int maxLevel = 5;
            while (level <= maxLevel)
            {
                bool bGameOver = MulaiMain(level);
                if (bGameOver)
                {
                    level++;
                }
            }
            Console.WriteLine("Selamat anda sudah mendapatkan semua kode rahasia, segera laporkan ke pusat komando ASAP");
        }
    }
}
