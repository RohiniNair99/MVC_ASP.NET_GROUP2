using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMeAPI.Models
{
    public class QuestionDetail
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
    }
}