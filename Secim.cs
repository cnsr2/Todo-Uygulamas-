using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Secim
    {
        public void SecimCagir()
        {
            List<Ekleme> listEkleme = new List<Ekleme>();
        SECİM_EKRANİ_DON:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int secenek = Convert.ToInt32(Console.ReadLine());
            Ekleme kartYarat = new Ekleme();
            switch (secenek)
            {
                case 1:
                    Console.WriteLine("TODO Line");
                    Console.WriteLine("*************************");
                    foreach (var item in listEkleme)
                    {
                        if (item.lineSecim == "TODO")
                        {
                            Console.WriteLine("Başlık       :" + item.baslık);
                            Console.WriteLine("İçerik       :" + item.icerik);
                            Console.WriteLine("Atanan Kişi  :" + item.kisi);
                            Console.WriteLine("Büyüklük     :" + item.büyüklük);
                            Console.WriteLine("-");
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("IN PROGRESS Line");
                    Console.WriteLine("*************************");
                    foreach (var item in listEkleme)
                    {


                        if (item.lineSecim == "IN PROGRESS")
                        {

                            Console.WriteLine("Başlık       :" + item.baslık);
                            Console.WriteLine("İçerik       :" + item.icerik);
                            Console.WriteLine("Atanan Kişi  :" + item.kisi);
                            Console.WriteLine("Büyüklük     :" + item.büyüklük);
                            Console.WriteLine("-");
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("DONE Line");
                    Console.WriteLine("*************************");
                    foreach (var item in listEkleme)
                    {
                        if (item.lineSecim == "DONE")
                        {

                            Console.WriteLine("Başlık       :" + item.baslık);
                            Console.WriteLine("İçerik       :" + item.icerik);
                            Console.WriteLine("Atanan Kişi  :" + item.kisi);
                            Console.WriteLine("Büyüklük     :" + item.büyüklük);
                            Console.WriteLine("-");
                        }

                    }
                    Console.WriteLine(" ");

                CASE1_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar İşlem Yapmak İstiyor Musunuz ? (Evet:e / Hayır: h)");
                    char a = Convert.ToChar(Console.ReadLine().ToLower());
                    if (a == 'e')
                    {
                        Console.WriteLine("Seçim Ekranına Yönlendiriliyorsunuz.");
                        goto SECİM_EKRANİ_DON;
                    }
                    else if (a == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                        goto CASE1_TEKRAR_SORGU;
                    }

                    break;

                case 2:
                    listEkleme.Add(kartYarat.KartEkleme());
                CASE2_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar İşlem Yapmak İstiyor Musunuz ? (Evet:e / Hayır: h)");
                    char k = Convert.ToChar(Console.ReadLine().ToLower());
                    if (k == 'e')
                    {
                        Console.WriteLine("Seçim Ekranına Yönlendiriliyorsunuz.");
                        goto SECİM_EKRANİ_DON;
                    }
                    else if (k == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                        goto CASE2_TEKRAR_SORGU;
                    }
                    break;
                case 3:
                SILME_DON:
                    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığını yazınız:");
                    string silinecekBaslık = Console.ReadLine().ToLower();
                    int count = 0;
                    for (int item = 0; item < listEkleme.Count; item++)
                    {
                        if (listEkleme[item].baslık == silinecekBaslık.ToLower())
                        {
                            listEkleme.RemoveAt(item);
                            Console.WriteLine("Silme İşlemi Başarılı");
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("Silmeyi Sonlandırmak için : (1)");
                        Console.WriteLine("Yeniden denemek için      : (2)");
                        char s = Convert.ToChar(Console.ReadLine().ToLower());
                        if (s == '2')
                        {
                            goto SILME_DON;
                        }
                        else
                        {
                            Console.WriteLine("İyi Günler ^^");
                        }
                    }
                CASE3_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar İşlem Yapmak İstiyor Musunuz ? (Evet:e / Hayır: h)");
                    char b = Convert.ToChar(Console.ReadLine().ToLower());
                    if (b == 'e')
                    {
                        Console.WriteLine("Seçim Ekranına Yönlendiriliyorsunuz.");
                        goto SECİM_EKRANİ_DON;
                    }
                    else if (b == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                        goto CASE3_TEKRAR_SORGU;
                    }
                    break;
                case 4:
                TASIMA_DON:
                    Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                    Console.WriteLine("Lütfen kart başlığını yazınız:");
                    string tasınacakKartBaslık = Console.ReadLine().ToLower();
                    int count1 = 0;
                    for (int i = 0; i < listEkleme.Count; i++)
                    {
                        if (listEkleme[i].baslık == tasınacakKartBaslık || listEkleme[i].baslık == tasınacakKartBaslık.ToUpper())
                        {
                            TASIMAYA_DON:
                            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı Seçiniz:");
                            Console.WriteLine("(1) TODO");
                            Console.WriteLine("(2) IN PROGRESS");
                            Console.WriteLine("(3) DONE");
                            int tasınacakLine = Convert.ToInt32(Console.ReadLine());
                            if (tasınacakLine == 1)
                            {
                               
                                    listEkleme[i].lineSecim = "TODO";
                                    Console.WriteLine("Taşıma İşlemi Başarılı");
                                
                            }
                            else if (tasınacakLine == 2)
                            {
                                    listEkleme[i].lineSecim = "IN PROGRESS";
                                    Console.WriteLine("Taşıma İşlemi Başarılı");
                            }
                            else if (tasınacakLine == 3)
                            {
                                    listEkleme[i].lineSecim = "DONE";
                                    Console.WriteLine("Taşıma İşlemi Başarılı");
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyin.");
                                goto TASIMAYA_DON;
                            }
                            count1++;
                        }
                    }
                    if (count1 == 0)
                    {
                        Console.Write("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("İşlemi Sonlandırmak için  : (1)");
                        Console.WriteLine("Yeniden denemek için      : (2)");
                        char f = Convert.ToChar(Console.ReadLine().ToLower());
                        if (f == '2')
                        {
                            goto TASIMA_DON;
                        }
                        else
                        {
                            Console.WriteLine("İyi Günler ^^");
                        }
                    }
                CASE4_TEKRAR_SORGU:
                    Console.WriteLine("Tekrar İşlem Yapmak İstiyor Musunuz ? (Evet:e / Hayır: h)");
                    char H = Convert.ToChar(Console.ReadLine().ToLower());
                    if (H == 'e')
                    {
                        Console.WriteLine("Seçim Ekranına Yönlendiriliyorsunuz.");
                        goto SECİM_EKRANİ_DON;
                    }
                    else if (H == 'h')
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                        goto CASE4_TEKRAR_SORGU;
                    }

                    break;

            }
        }
    }
}
