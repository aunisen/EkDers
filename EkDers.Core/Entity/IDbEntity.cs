using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Core.Entity
{
    public interface IDbEntity
    {
          Guid Id { get; set; }
          DateTime CreateDate { get; set; }
        bool IsDeleted { get; set; }
        

    }
}
