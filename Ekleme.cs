using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Ekleme
    {
        public string baslık;
        public string icerik;
        public string büyüklük;
        public string kisi;
        public string lineSecim;
        public Ekleme KartEkleme()
        {
           Ekleme kartEkleme = new Ekleme();
            Console.WriteLine("Başlık Giriniz                                 :");
            kartEkleme.baslık = Console.ReadLine().ToLower();
            Console.WriteLine("İçerik Giriniz                                 :");
            kartEkleme.icerik = Console.ReadLine().ToLower();
        BUYUKLUK_DON:
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int buyukluk = Convert.ToInt32(Console.ReadLine().ToLower());
            if (buyukluk == (int)EnumBoyut.XS)
                kartEkleme.büyüklük = "XS";
            else if (buyukluk == (int)EnumBoyut.S)
                kartEkleme.büyüklük = "S";
            else if (buyukluk == (int)EnumBoyut.M)
                kartEkleme.büyüklük = "M";
            else if (buyukluk == (int)EnumBoyut.L)
                kartEkleme.büyüklük = "L";
            else if (buyukluk == (int)EnumBoyut.XL)
                kartEkleme.büyüklük = "XL";
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                goto BUYUKLUK_DON;
            }
            
            Console.WriteLine("Kişi Seçiniz                                   :");
            kartEkleme.kisi = Console.ReadLine().ToLower();
            LINE_DON:
            Console.WriteLine("Line Seçiniz (TODO:1, IN PROGRESS:2, DONE:3)   :");
            int lineSecim = Convert.ToInt32(Console.ReadLine().ToLower());
            if (lineSecim == 1)
                kartEkleme.lineSecim = "TODO";
            else if (lineSecim == 2)
                kartEkleme.lineSecim = "IN PROGRESS";
            else if (lineSecim == 3)
                kartEkleme.lineSecim = "DONE";
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                goto LINE_DON;
            }

            return kartEkleme;
        }
    }
    public enum EnumBoyut
    {
        XS = 1,
        S,
        M,
        L,
        XL,
    }
}
