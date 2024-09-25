using EkDers.Entity.DbEntity;
using EkDers.Entity.DTO.OgretmenDTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Repositories.Concrete
{
    public class OgretmenProgramRepository : RepositoryGenericNonAsync<OgretmenProgram>
    {
        public List<OgretmenProgramListItemDTO> GetOgretmenProgarms(Guid? Id=null)
        {
            var result = GetAll();
            if (Id != null) result=GetAll(c => c.OgretmenId == Id);
           
            return result.Select(c => new OgretmenProgramListItemDTO
            {
                PazartesiDersSaati = c.PazartesiDersSaati,
                PazartesiEkDersSaati = c.PazartesiDersSaati,
                SaliDersSaati = c.SaliDersSaati,
                SaliEkDersSaati = c.SaliEkDersSaati,
                CarsambaDersSaati = c.CarsambaDersSaati,
                CarsambaEkDersSaati = c.CarsambaEkDersSaati,
                PersembeDersSaati = c.PersembeDersSaati,
                PersembeEkDersSaati = c.PersembeEkDersSaati,
                CumaDersSaati = c.CumaDersSaati,
                CumaEkDersSaati = c.CumaEkDersSaati,
                CumartesiDersSaati = c.CumartesiDersSaati,
                CumartesiEkDersSaati = c.CumartesiEkDersSaati,
                PazarDersSaati = c.PazarDersSaati,
                PazarEkDersSaati = c.PazarEkDersSaati,
                EkDersKodAd = c.EkdersKodu.KodAd,
                EkdersKoduId=c.EkdersKoduId,
                Id=c.Id,
                OgretmenAd= $"{c.Ogretmen.Ad} {c.Ogretmen.Soyad}",
                OgretmenId= c.OgretmenId,
                ProgramGroubuId = c.ProgramGroupId   
            }).ToList();
             


        }
     
    }
}
