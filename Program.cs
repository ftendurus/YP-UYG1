using System;

namespace YP_UYG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Unvanlar
            Unvan unvan1 = new Unvan();
            unvan1.Id = 1;
            unvan1.akademikMI = true;
            unvan1.unvanveri = "Profesor";

            Unvan unvan2 = new Unvan();
            unvan2.Id = 2;
            unvan2.akademikMI = true;
            unvan2.unvanveri = "Docent";

            Unvan unvan3 = new Unvan();
            unvan3.Id = 3;
            unvan3.akademikMI = true;
            unvan3.unvanveri = "Daire Baskani";
            #endregion

            #region AkademikPersonel
            AkademikPersonel apersonel1 = new AkademikPersonel();
            apersonel1.Id = 1;
            apersonel1.kurumsicil = "A-1234";
            apersonel1.Ad = "Ahmet";
            apersonel1.soyad = "Test";
            apersonel1.tc = "2112121111";
            apersonel1.akademikUnvan = unvan2;
            

            AkademikPersonel apersonel2 = new AkademikPersonel();
            apersonel2.Id = 2;
            apersonel2.kurumsicil = "A-21321";
            apersonel2.Ad = "Ali";
            apersonel2.soyad = "Veli";
            apersonel2.tc = "2313213";
            apersonel2.akademikUnvan = unvan1;
            #endregion

            #region Dersler
            Dersler ders1 = new Dersler();
            ders1.Id = 1;
            ders1.dersAdi = "Programlama";
            ders1.dersiVeren = apersonel1;
            ders1.AKTS = 5;
            ders1.dersKodu = "001";
            ders1.yil = 2022;
            ders1.donem = "bahar";
            ders1.kredi = 4;

            Dersler ders2 = new Dersler();
            ders2.Id = 2;
            ders2.dersAdi = "Matematik";
            ders2.dersiVeren = apersonel2;
            ders2.AKTS = 5;
            ders2.dersKodu = "002";
            ders2.yil = 2022;
            ders2.donem = "bahar";
            ders2.kredi = 4;

            Dersler[] derslerDizi = new Dersler[2];
            derslerDizi[0] = ders1;
            derslerDizi[1] = ders2;

            #endregion

            #region IletisimTip
            IletisimTip tip1 = new IletisimTip();
            tip1.Id = 1;
            tip1.veri = "Telefon";

            IletisimTip tip2 = new IletisimTip();
            tip2.Id = 2;
            tip2.veri = "Mail";
            
            IletisimTip tip3 = new IletisimTip();
            tip3.Id = 3;
            tip3.veri = "Adres";
            #endregion

            #region IletisimBilgileri
            Iletisim iletisim1  = new Iletisim();
            iletisim1.Id = 1;
            iletisim1.iletisimTip = tip1;
            iletisim1.veri = "05552222222";
            
            Iletisim iletisim2 = new Iletisim();
            iletisim2.Id = 2;
            iletisim2.iletisimTip = tip2;
            iletisim2.veri = "simple@simple.com";

            Iletisim iletisim3 = new Iletisim();
            iletisim3.Id = 3;
            iletisim3.iletisimTip = tip3;
            iletisim3.veri = "Ornek Cadde ornek mahalle";

            Iletisim[] iletisimDizi = new Iletisim[3];
            iletisimDizi[0] = iletisim1;
            iletisimDizi[1] = iletisim2;
            iletisimDizi[2] = iletisim3;

            #endregion

            #region OgrenciBilgileri
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Id = 1;
            ogrenci1.ogrenciAdi = "Ali";
            ogrenci1.ogrenciSoyad = "Veli";
            ogrenci1.ogrenciNo = 321321;
            ogrenci1.tcNo = "32132132";
            ogrenci1.dogumTarihi = DateTime.Parse("11.11.1999");
            ogrenci1.kayitTarihi = DateTime.Parse("10.09.2022");
            ogrenci1.danisman = apersonel1;
            ogrenci1.alinanDersler = derslerDizi;
            ogrenci1.iletisimBilgileri = iletisimDizi;

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Id = 2;
            ogrenci2.ogrenciAdi = "Ahmet";
            ogrenci2.ogrenciSoyad = "test";
            ogrenci2.ogrenciNo = 3213213;
            ogrenci2.tcNo = "321321";
            ogrenci2.dogumTarihi = DateTime.Parse("01.01.2001");
            ogrenci2.kayitTarihi = DateTime.Parse("11.11.2020");
            ogrenci2.danisman = apersonel2;
            ogrenci2.alinanDersler = derslerDizi;
            ogrenci2.iletisimBilgileri= iletisimDizi;
            #endregion


        }
    }
}
