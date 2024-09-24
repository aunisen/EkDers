using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Entity.DTO.OgretmenDTO
{
    public class OgretmenListItemDTO
    {
        public Guid Id { get; set; }
        public Guid BransId { get; set; }
        public string BransAd { get; set; }
        public Guid GorevId { get; set; }
        public string GorevAd { get; set; }
        public Guid KariyerBasamakId { get; set; }
        public string KariyerBasamakAd { get; set; }
        public Guid MezuniyetId { get; set; }
        public string MezuniyetAd { get; set; }
        public string AdSoyad { get { return $"{Ad} {Soyad}"; } }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Tckn { get; set; }
        

    }
}
