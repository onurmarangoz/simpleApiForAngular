using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleApiForAngular.Models;
using System.Collections.Generic;
using System.Linq;

namespace simpleApiForAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private List<Project> projects = null;
        public ProjectsController()
        {
            var projects = new List<Project>
            {
                new Project { CategoryId = 1, Id = 1, Name = "Genel Sağlık Uygulamaları", Description = "bla bla",
                    Tasks = new List<Task> {
                        new Task {  Id = 1, Name = "Veri Tabanı Configurasyonu", Description = "Test", ExpectedDate = System.DateTime.Now.AddDays(18), isDone = false},
                        new Task {  Id = 2, Name = "Authentication İşlemleri", Description = "Test", ExpectedDate = System.DateTime.Now.AddDays(35), isDone = false}
                    },
                },
                new Project {CategoryId = 2, Id = 2, Name = "Bankacılık", Description = "bla bla",
                    Tasks = new List<Task> {
                        new Task {  Id = 1, Name = "BDD Alt yapısı", Description = "Test", ExpectedDate = System.DateTime.Now.AddMonths(1), isDone = false},
                        new Task {  Id = 2, Name = "Text Caseleri yazılacak", Description = "Test", ExpectedDate = System.DateTime.Now.AddMonths(3), isDone = false}
                    },
                },
                new Project {CategoryId = 2, Id = 3, Name = "Devlet hataneleri Otomasyonu", Description = "bla bla",
                    Tasks = new List<Task> {
                        new Task {  Id = 1, Name = "Proje Alt yapısı", Description = "Test", ExpectedDate = System.DateTime.Now.AddMonths(1), isDone = false},
                        new Task {  Id = 2, Name = "devops mimarisi", Description = "Test", ExpectedDate = System.DateTime.Now.AddMonths(3), isDone = false},
                         new Task {  Id = 3, Name = "Jenkins mimarisi", Description = "Test", ExpectedDate = System.DateTime.Now.AddMonths(3), isDone = false}
                    },
                }
            };

        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(projects);
        }
        [HttpGet("{id}")]
        public IActionResult GetByCategory(int id)
        {
            var result = this.projects.Where(p => p.CategoryId == id);
            return Ok(result);
        }
    }
}
