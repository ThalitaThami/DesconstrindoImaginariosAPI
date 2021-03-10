using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Models
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
