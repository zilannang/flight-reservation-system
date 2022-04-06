using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ZİLAN ANĞ 150101025

namespace Reservation
{
    static class HelperClass
    {
        
        public static List<HavaLimani> HavaLimanlari = new List<HavaLimani>();
        public static List<HavaYolu> HavaYollari = new List<HavaYolu>();
        public static List<Ucak> Ucaklar = new List<Ucak>();
        public static List<Ucus> Ucuslar = new List<Ucus>();
        public static List<Yolcu> Yolcular = new List<Yolcu>();
        public static List<Kisi> Kisiler = new List<Kisi>();
        
        public static void HavalimaniOlustur(string sehir, string isim, string kod)
        {
            HavaLimani havaLimani = new HavaLimani();
            havaLimani.Sehir = sehir;
            havaLimani.Isim = isim;
            havaLimani.Kod = kod;
        }

        public static void HavaYoluOlustur(string isim)
        {
            HavaYolu havaYolu = new HavaYolu();
            havaYolu.Isim = isim;
        }

        public static void UcakOlustur(string code, int kapasite)
        {
            Ucak ucak = new Ucak();
            ucak.Code = code;
            ucak.Kapasite = kapasite;
        }
       

        public static void UcusOlustur(HavaLimani kalkis, HavaLimani varis, string ucusKodu, Ucak ucak, DateTime tarih, decimal ucret)
        {
            Ucus ucus = new Ucus();
            ucus.Kalkıs = kalkis;
            ucus.Varıs = varis;
            ucus.UcusKodu = ucusKodu;
            ucus.Ucak = ucak;
            ucus.Tarih = tarih;
            ucus.Ucret = ucret;
        }

       
        public static void YolcuEkle(Ucus ucus, Yolcu yolcu)
        {
            Yolcu _yolcu = new Yolcu();
            _yolcu.Ucus = ucus;
            _yolcu.yolcu = yolcu;
        }


        public static void KisiEkle(string isim, string soyIsim, int id)
        {
            Kisi kisi = new Kisi();
            kisi.Isim = isim;
            kisi.SoyIsim = soyIsim;
            kisi.Id = id;
        }

       
        //bir ucagı bir havayoluna ekle.
        public static void UcakEkle(Ucak _ucak, HavaYolu havaYolu)
        {
            HavaYolu havayolu = new HavaYolu();
            havayolu = new Havayolu (Ucak);

        }

         //ucusa ait bos koltuklari listeler.
        //eğer bu metodu tamamlayamazsanız.
        //uçağın kapasitesi kadar int. değeri boş koltuklar
        //listesine ekleyin. Ancak puan kırılacak.
        public static List<int> BosKoltukListele(Ucus ucus)
        {
            List<int> bosKoltuklar = new List<int>();

            bosKoltuklar.Add(KoltukBosMu());
                 return bosKoltuklar;

        }

    }
}

