using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucak_Rezervasyonu
{
    internal class proje
    {
        public static string musteriAdSoyad;
        static void Main(string[] args)
        {

            DateTime TarihveSaat1 = new DateTime(2022, 05, 20, 13, 30, 0);
            DateTime TarihveSaat2 = new DateTime(2022, 05, 22, 13, 30, 0);
            DateTime TarihveSaat3 = new DateTime(2022, 05, 27, 13, 30, 0);
            DateTime TarihveSaat4 = new DateTime(2022, 05, 12, 13, 30, 0);

            Ucak ucak1 = new Ucak();
            ucak1.bakimtarihi = TarihveSaat1;
            ucak1.ucakModel = "yolcu uçağı";
            ucak1.ucakRengi = "beyaz";
            ucak1.seriNo = 765;
            ucak1.kackisilik = 200;
            ucak1.ucakomru = 25;
            ucak1.ucakagirligi = 170;


            Musteri musteri1 = new Musteri();
            Console.WriteLine("musterinin adı soyadı ?");
            musteri1.AdSoyad = (Console.ReadLine());
            Console.WriteLine("musterinin cinsiyeti ? ");
            musteri1.Cinsiyet = (Console.ReadLine());
            Console.WriteLine("musterinin yaşı ?");
            musteri1.yas = Convert.ToInt32(Console.ReadLine());
            musteri1.Yasli = "hayır";
            musteri1.Genc = "evet";
            Console.WriteLine("engelli misiniz, evet ya da hayır ");
            musteri1.Engelli = (Console.ReadLine());
            Console.WriteLine("musterinin telefon numarası ?");
            musteri1.telefonNo = (Console.ReadLine());

            Lokasyon lokasyon1 = new Lokasyon();
            Console.WriteLine("hangi ülke ?");
            lokasyon1.Ulke = (Console.ReadLine());
            Console.WriteLine("hangi şehir?");
            lokasyon1.Sehir = (Console.ReadLine());
            Console.WriteLine("hangi havaalanı ?");
            lokasyon1.Havaalani = (Console.ReadLine());
            lokasyon1.kapali = 'K';


            Rezervasyon rezervasyon1 = new Rezervasyon();
            rezervasyon1.dolukoltuk = 100;
            //rezervasyon1.Ucak = "aaaa";
            rezervasyon1.lokasyon = (lokasyon1.Ulke + " " + lokasyon1.Sehir);
            Console.WriteLine("Seçtiğiniz Lokasyon:" + rezervasyon1.lokasyon);
            rezervasyon1.Musteri = musteri1.AdSoyad;
            Console.WriteLine("musterinin Ad Soyadı:" + rezervasyon1.Musteri);
            rezervasyon1.TarihveSaat = TarihveSaat2;
            Console.WriteLine("Tarih:" + rezervasyon1.TarihveSaat);
            rezervasyon1.boskoltuk = ucak1.kackisilik - rezervasyon1.dolukoltuk;
            Console.WriteLine("Boş koltuk sayısı: " + rezervasyon1.boskoltuk);
            Console.WriteLine("Koltuk numarasını seçiniz\nKoltuk numaraları: 'a1-100,b1-100'\nÖrnek:'a5' veya 'b2'");
            rezervasyon1.KoltukNo = (Console.ReadLine());
            Console.WriteLine("seçtiğiniz koltuk no: " + rezervasyon1.KoltukNo);
            rezervasyon1.acik = 'A';
            rezervasyon1.kapali = 'K';



            //Console.WriteLine(TarihveSaat1.ToString("dd.MM.yyyy HH:mm"));

        }
    }
}
