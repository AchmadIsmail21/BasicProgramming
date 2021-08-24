using System;
using System.Collections.Generic;

namespace TugasMCCBioskop
{
     
 
    class Program
    {
        public static List<object> films = new List<object>();
        // untuk method pilihfilm
        public static string[] nameFilms = new string[20] ;
        public static int[] prices = new int[20];
        public static double totalPrice;
        public static double total; // harga di kali banyaknya tiket
        public static int selectMenu;

        //variabel banyak tiket
        public static int manyTicket;

        //untuk method studio
        public static string[] studioFilm = new string[20];

        //variabel penampung film di pilih dan studio film 
        public static string selectedMovie;
        public static string showStudio;

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("1. Pilih Film Bioskop");
                Console.WriteLine("2. Cetak Ticket");
                Console.WriteLine("3. Keluar");
                Console.Write("Silahkan Pilih Menu : ");
                try
                {
                    selectMenu = Convert.ToInt32(Console.ReadLine());
                    switch (selectMenu)
                    {
                        case 1:
                            SelectFilm();
                            break;
                        case 2:
                            PrintTicket();
                            break;
                        case 3:
                            Out();
                            break;
                        default:
                            break;


                    }
            }
                catch (Exception e)
                {
                    Console.WriteLine("Inputan Tidak Boleh Menggunakan Huruf / Kosong");
                }
  
        }

        static void SelectFilm()
        {
            int select = 0;
            nameFilms = new string[] { "1. Iron Man", "2. Quiet Palace", "3. Bird Box" };
            prices = new int[] { 45000, 40000, 50000 };
            studioFilm = new string[] { "1. Studio A" , "2. Studio B" , "3. Studio C" };
            foreach (string nama in nameFilms)
            {
                Console.WriteLine(nama);
            }

            try
            {
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine(nameFilms[0]);
                        Console.WriteLine(prices[0]);
                        Console.WriteLine(studioFilm[0]);

                        break;
                    case 2:
                        Console.WriteLine(nameFilms[1]);
                        Console.WriteLine(prices[1]);
                        Console.WriteLine(studioFilm[1]);
                        break;
                    case 3:
                        Console.WriteLine(nameFilms[2]);
                        Console.WriteLine(prices[2]);
                        Console.WriteLine(studioFilm[2]);
                        break;
                    default:
                        Console.WriteLine("Film Tidak Ada");
                        break;
                }
                Console.Clear();

                Console.WriteLine($"Anda Telah Memilih Film : {nameFilms[select - 1]}");

                Console.Write("Berapa Banyak Tiket yang ingin Di Pesan : ");
                manyTicket = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Total Tiket yang Di pesan : {manyTicket}");

                total = prices[select - 1] * manyTicket;
                totalPrice = total - (total * DiskonFilm(manyTicket));
                Console.WriteLine($"Total Harga yang Dibayarkan {totalPrice}");

                selectedMovie = nameFilms[select - 1];
                showStudio = studioFilm[select - 1];

            }
            catch (Exception e)
            {
                Console.WriteLine("Inputan Tidak Boleh Menggunakan Huruf / Kosong");
            }

            BackToMenu();
        }
        static void PrintTicket() {
            Console.Clear();
            Console.WriteLine($"Film Yang di Pilih : {selectedMovie}");
            Console.WriteLine($"Film Anda ada di Studio : {showStudio}");
            Console.WriteLine($"Total Tiket yang di Pesan : {manyTicket}");
            Console.WriteLine($"Total Harga : {totalPrice}");
            BackToMenu();
        }

        static void Out() {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("Terima Kasih Sudah Menggunakan Aplikasi Ini");
            Console.WriteLine("===========================================");
        }


        static void BackToMenu() {
            Console.ReadKey(true);
            Menu();
        }
        static double DiskonFilm(int ticket) {
            if (ticket > 4) {
                return 0.1;
            }
            return 0;
        }

    }
}
