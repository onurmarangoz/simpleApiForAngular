using System;

namespace simpleApiForAngular.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime ExpectedDate { get; set; }

        public bool isDone { get; set; }
    }
}
