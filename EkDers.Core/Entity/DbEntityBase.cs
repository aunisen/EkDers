using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Core.Entity
{
    public class DbEntityBase : IDbEntity
    {
        public Guid Id { get; set; }=Guid.NewGuid();    
        public DateTime CreateDate { get; set; }=DateTime.Now;  
        public bool IsDeleted { get; set; }=false;  
    }
}
