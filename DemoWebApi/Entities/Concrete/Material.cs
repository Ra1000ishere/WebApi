using DemoWebApi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Entities.Concrete
{
    public class Material:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Lesson Lesson { get; set; }
        public int LessonId { get; set; }
        public int UserId { get; set; } //Creator Id

    }
}
