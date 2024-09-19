using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class EkdersResult:DbEntityBase
    {
        public Guid PersonelId { get; set; }
        public Personel Personel { get; set; }

        public Guid KodId { get; set; }
        public EkdersKodu Kod { get; set; }


        public Guid DonemId { get; set; }
        public Donem Donem { get; set; }

        public string Data { get; set; } 
        public int Gun0 { get; set; }
        public int Gun1 { get; set; }
        public int Gun2 { get; set; }
        public int Gun3 { get; set; }
        public int Gun4 { get; set; }
        public int Gun5 { get; set; }
        public int Gun6 { get; set; }
        public int Gun7 { get; set; }
        public int Gun8 { get; set; }
        public int Gun9 { get; set; }
        public int Gun10 { get; set; }
        public int Gun11 { get; set; }
        public int Gun13 { get; set; }
        public int Gun14 { get; set; }
        public int Gun15 { get; set; }
        public int Gun16 { get; set; }
        public int Gun17 { get; set; }
        public int Gun18 { get; set; }
        public int Gun19 { get; set; }
        public int Gun20 { get; set; }
        public int Gun21 { get; set; }
        public int Gun22 { get; set; }
        public int Gun23 { get; set; }
        public int Gun24 { get; set; }
        public int Gun25 { get; set; }
        public int Gun26 { get; set; }
        public int Gun27 { get; set; }
        public int Gun28 { get; set; }
        public int Gun29 { get; set; }
        public int Gun30 { get; set; }







    }
}
