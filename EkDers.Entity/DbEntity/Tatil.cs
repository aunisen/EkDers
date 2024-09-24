using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class Tatil:DbEntityBase
    {
        public string TatilAd { get; set; }
        public string TatilTuru { get; set; }
        public DateOnly BaslangicTarihi { get; set; }
        public bool Yarimgunvarmi { get; set; }
        public int GunSayisi { get; set; }
        public bool EkDersKesilirmi { get; set; }
        public string RaporKodu { get; set; }


        public override string ToString()
        {
            return $"{TatilAd}";
        }
    }
}
