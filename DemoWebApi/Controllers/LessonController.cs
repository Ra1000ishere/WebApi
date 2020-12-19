using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebApi.DataAccess.EntityFramework.Abstract;
using DemoWebApi.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private ILessonRepository _lessonRepository;


        public LessonController(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        /// <summary>
        /// Get Lesson By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var lesson = _lessonRepository.Get(l=>l.Id==id);
            if (lesson==null)
            {
                return BadRequest();
            }
            return Ok(lesson);
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var lessons = _lessonRepository.GetList();
            if (lessons==null)
            {
                return NoContent();
            }
            return Ok(lessons);
        }
        [HttpPost]
        public IActionResult Add(Lesson lesson)
        {
            var added= _lessonRepository.Add(lesson);
            return Created(String.Empty,added);
        }
        [HttpDelete]
        public IActionResult Delete(Lesson lesson)
        {
            _lessonRepository.Delete(lesson);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Lesson lesson)
        {
            _lessonRepository.Update(lesson);
            return NoContent();
        }

    }
}
