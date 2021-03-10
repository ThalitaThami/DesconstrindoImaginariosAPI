using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Models
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
