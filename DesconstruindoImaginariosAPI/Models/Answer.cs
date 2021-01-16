using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesconstruindoImaginariosAPI.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public Question Question { get; set; }
    }
}
