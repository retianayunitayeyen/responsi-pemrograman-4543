using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectpenjualan
{
    class program
    {
        //deklarasi object collection untuk menampung object penjualan
        static List<string> daftarpenjual = new list<string >();

        static void main(string agrs)
        {
            Console.Title = "Responsi UAS matakuliah pemrograman";

            while (true)
            {
                Tampilmenu();

                Console.Write("\nNomor Menu {1..4:");
                int nomorMenu
            convert.Toln32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        tambahpenjualan();
                        break;

                    case 2:
                        Tampilpenjualan();
                        break;

                    case 3://keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilanMenu()
        {
            Console.Clear();

            //PERINTAH:lengkapi kode untuk menampilkan menu 
        }
        static void Tambahpenjualan()
        {
            Console.Clear();

            //PERINTAH:lengkapi kode untuk menambahkan penjualan kedalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
        static void Tampilpenjualan()
        {
            Console.Clear();

            //PERINTAH: lengkapi kode untuk menampilkan data penjualan yang di dalam collection 
        
        
            
               




    


        
    



    
