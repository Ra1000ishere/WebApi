using DemoWebApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.DataAccess.EntityFramework.Abstract
{
   public interface IMaterialRepository:IEntityRepository<Material>
    {
    }
}
