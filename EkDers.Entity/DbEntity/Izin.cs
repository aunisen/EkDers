using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DbEntity
{
    public class Izin:DbEntityBase
    {

        public Izin()
        {
            
        }
        public Izin(Guid izinTurId, DateOnly baslangictarihi, int gunsayisi)
        {
            this.IzinTuruId = izinTurId;
            BaslagicTarihi = baslangictarihi;
            GunSayisi = gunsayisi;
        }
        public DateOnly BaslagicTarihi { get; set; }
        public int GunSayisi { get; set; }
        public string Aciklama { get; set; }
        public bool EkDerskesilecekmi { get; set; } = true;


        public Guid IzinTuruId { get; set; }
        public IzinTuru IzinTuru { get; set; }

        public Guid PersonelId { get; set; } 
        public Personel Personel { get; set; }

        public ICollection<EkdersResult> EkDersResults { get; set; }
    }
}
