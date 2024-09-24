using EkDers.Data.Context;
using EkDers.Entity.DbEntity;
using EkDers.Entity.DTO.OgretmenDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Repositories.Concrete
{
    public class OgretmenRepository : RepositoryGenericNonAsync<Ogretmen>
    {
        public List<OgretmenListItemDTO> Ogretmenlistesi( )
        {
          return  GetAll(c=>!c.IsDeleted).Select(x=>new OgretmenListItemDTO {
                Ad=x.Ad,
                BransAd=x.Brans.BransAd,
                BransId=x.BransId,
                GorevAd=x.Gorev.GorevAd,
                GorevId=x.GorevId,  
                Id=x.Id,    
                KariyerBasamakAd= x.KariyerBasamagi.Ad,
                KariyerBasamakId = x.KariyerBasamagiId,
                MezuniyetAd= x.MezuniyetTuru.MezuniyetTurAd,
                MezuniyetId= x.MezuniyetTuruId,
                Soyad = x.Soyad,
                Tckn= x.TCKN,
                Telefon = x.Telefon 
          
          }).ToList();
        }
    }
}
