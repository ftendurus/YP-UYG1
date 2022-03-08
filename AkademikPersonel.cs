using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_UYG1
{
    internal class AkademikPersonel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string soyad { get; set; }
        public string kurumsicil { get; set; }
        public string tc { get; set; }
        //public IletisimTip[] iletisim { get; set; }
        public Unvan akademikUnvan { get; set; }

    }
}
