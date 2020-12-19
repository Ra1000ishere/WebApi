using DemoWebApi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Entities.Concrete
{
    public class Lesson: IEntity
    {
        public Lesson()
        {
            Materials = new List<Material>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public IList<Material> Materials { get; set; }
    }
}
