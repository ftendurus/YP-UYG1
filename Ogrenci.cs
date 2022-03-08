using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_UYG1
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string ogrenciAdi { get; set; }
        public string ogrenciSoyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public DateTime kayitTarihi { get; set; }
        public int ogrenciNo { get; set; }
        public string tcNo { get; set; }
        public AkademikPersonel danisman { get; set; }
        public Iletisim[] iletisimBilgileri { get; set; }
        public Dersler[] alinanDersler { get; set; }

    }
}
