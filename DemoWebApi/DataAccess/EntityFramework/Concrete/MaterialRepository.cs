using DemoWebApi.DataAccess.EntityFramework.Abstract;
using DemoWebApi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.DataAccess.EntityFramework.Concrete
{
    public class MaterialRepository:EfEntityRepositoryBase<Material,DemoContext>,IMaterialRepository
    {
    }
}
