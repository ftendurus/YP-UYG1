using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_UYG1
{
    internal class Dersler
    {
        public int Id { get; set; }
        public string dersKodu { get; set; }
        public string dersAdi { get; set; }
        public int AKTS { get; set; }
        public int kredi { get; set; }
        public int yil { get; set; }
        public string donem { get; set; }
        public AkademikPersonel dersiVeren { get; set; }
    }
}
