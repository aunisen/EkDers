using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace EkDers.Entity.DbEntity
{
    public class Personel:DbEntityBase
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public Guid GorevId { get; set; }
        public Gorev Gorev { get; set; }
        public Guid BransId { get; set; }
        public Brans Brans { get; set; }
    }
}
