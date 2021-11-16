using System.Collections.Generic;

namespace simpleApiForAngular.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Task> Tasks { get; set; }

        public int CategoryId  { get; set; }


    }
}
