using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class AnswerImage
    {
        public enum Question
        {
            Earth, Computer
        }
        public int AnswerImageId { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string Url { get; set; }

    }
}
