using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulamasi
{
    class Rehber
    {
        List<Kisi> Kisiler = new List<Kisi>();

        public Rehber()
        {
            Kisiler.Add(new Kisi("Halil", "Özdemir", 123));
            Kisiler.Add(new Kisi("Ali", "Ata", 234));
            Kisiler.Add(new Kisi("Murat", "Burda", 446));
            Kisiler.Add(new Kisi("Ayse", "Tatlı", 564));
            Kisiler.Add(new Kisi("Fatma", "Yok", 678));
        }
        public void KisiEkle()
        {
            Console.Write("Lütfen isim giriniz             :");
            string ad = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string soyad = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            int numara = int.Parse(Console.ReadLine());
            
            Kisiler.Add(new Kisi(ad, soyad, numara));
            Console.Clear();
            
            Console.WriteLine("işlem başarılı...");
            AnaMenü();
          
            

        }
        public void KisileriListele()
        {
            Console.WriteLine("Rehber Nasıl Sıralansın.");
            Console.WriteLine("********************************");
            Console.WriteLine("");
            Console.WriteLine("(1) A-Z şekilde");
            Console.WriteLine("(2) Z-A şelilde");
            Kisiler.Sort((i1, i2) => i1.Ad1.CompareTo(i2.Ad1));
            string secim=Console.ReadLine();
            Console.Clear();
            switch (secim)
            {
                case "1":
                    RehberSirali();
                    break;
                case "2":
                    Kisiler.Reverse();
                    RehberSirali();
                    break;
                default:
                    Console.WriteLine("Hata şeçim yaptınız. İşlem iptal edildi");
                    break;
            }

            AnaMenü();
            
            
        }
        public void KisiSilme()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranankisi = Console.ReadLine();

            bool kontrol = false;

            string secim;

            int index = KisiBulma(aranankisi);



            if (index > -1)
            {

                Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", Kisiler[index].Ad1, Kisiler[index].Soyad1);

                secim = Console.ReadLine();
                Console.Clear();
                kontrol = true;
                switch (secim)
                {
                    case "y":
                        Kisiler.Remove(Kisiler[index]);
                        Console.WriteLine("Kişi Silindi.");

                        break;
                    case "n":
                        Console.WriteLine("İşlem iptal edildi.");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız");

                        break;
                }
                AnaMenü();

            }



            if (!kontrol)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string secim1 = Console.ReadLine();
                Console.Clear();

                switch (secim1)
                {
                    case "1":
                        Console.WriteLine("işlem Sonlandı.");
                        
                        kontrol = true;

                        break;
                    case "2":
                        KisiSilme();
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız.İşlem Sonlandı...");
                        break;
                }
                AnaMenü();
            }
        }
        public void KisiGuncelleme()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranankisi = Console.ReadLine();
            int index = KisiBulma(aranankisi);
            if (index > -1)
            {
                Console.WriteLine("**********Kişi Bulundu!************");
                KisiGöster(index);

                Console.Write("Yeni Numarayı giriniz :");
                int yenino = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} {1} isimli kişi rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)", Kisiler[index].Ad1, Kisiler[index].Soyad1);

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "y":
                        Kisiler[index].Numara1 = yenino;
                        Console.WriteLine("İşlem tamamlandı..");
                        KisiGöster(index);
                        Console.WriteLine("*****************************");

                        break;
                    case "n":
                        Console.WriteLine("İşlem iptal edildi.");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız");

                        break;
                }
                

            }



            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için              : (2)");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "2":
                        KisiGuncelleme();
                        break;
                    case "1":
                        Console.WriteLine("İşlem iptal edildi.");
                        break;
                   default:
                      Console.WriteLine("Hatali tuşlama... İşlem Sonlandı...");
                      break;
                }


            }
            AnaMenü();

        }
        public void RehberdeAra()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();
           

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string Aranankisi = Console.ReadLine();
                    KisiArayıpBulma(Aranankisi);
                    break;
                case "2":
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin Numarasını giriniz:");
                    int ArananNumara =Convert.ToInt32(Console.ReadLine());
                    KisiArayıpBulma(ArananNumara);
                    break;
                default:
                    Console.WriteLine("Hata tuşlama Yaptınınz...İşlem iptal edildi");
                    break;
            }

            AnaMenü();


        }

        public int KisiBulma(string param)
        {
            int index = -1;

            for (int i = 0; i < Kisiler.Count; i++)
            {
                if (Kisiler[i].Ad1.Contains(param) || Kisiler[i].Soyad1.Contains(param))
                {
                    index = i;

                }

            }

            return index;
        }
        public void KisiArayıpBulma(string param)
        {
            bool kontrol = false;  
            
            for (int i = 0; i < Kisiler.Count; i++)
            {
                if (Kisiler[i].Ad1.Contains(param) || Kisiler[i].Soyad1.Contains(param))
                {
                    KisiGöster(i);
                    kontrol = true;

                }

            }
            if (kontrol == false)
                Console.WriteLine("Eşleşen hiç bir sonuc yok");
                Console.WriteLine("******************************");

        }
        public void KisiArayıpBulma(int param)
        {
            bool kontrol = false;
            for (int i = 0; i < Kisiler.Count; i++)
            {
                string Numara = Kisiler[i].Numara1.ToString();
                string ArananNumarama=param.ToString();

                if (Numara.Contains(ArananNumarama))
                {
                    KisiGöster(i);
                    kontrol = true;
                        
                 
                    
                }

            }
            if(kontrol==false)
                Console.WriteLine("Eşleşen hiç bir sonuç yok");
                Console.WriteLine("******************************");

        }

        public void KisiGöster(int index)
        {
            
                Console.WriteLine("isim :{0}", Kisiler[index].Ad1);
                Console.WriteLine("Soyisim :{0}", Kisiler[index].Soyad1);
                Console.WriteLine("Telefon Numarası: {0}", Kisiler[index].Numara1);
           
        }
        public void RehberSirali()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in Kisiler)
            {
                Console.WriteLine("isim :{0}", kisi.Ad1);
                Console.WriteLine("Soyisim :{0}", kisi.Soyad1);
                Console.WriteLine("Telefon Numarası: {0}", kisi.Numara1);
                Console.WriteLine("-");
            }
        }
        public void AnaMenü()
        {
            Console.WriteLine("Ana menüye gitmek için herhangi bir tuşa basın...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}

