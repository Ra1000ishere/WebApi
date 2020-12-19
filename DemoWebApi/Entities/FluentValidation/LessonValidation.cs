using DemoWebApi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Entities.FluentValidation
{
    public class LessonValidation:AbstractValidator<Lesson>
    {
        public LessonValidation()
        {
            RuleFor(l => l.Name).NotEmpty();
            RuleFor(l => l.Description).NotEmpty();
            RuleFor(l => l.Description).Length(10, 1000);
            
        }
    }
}
