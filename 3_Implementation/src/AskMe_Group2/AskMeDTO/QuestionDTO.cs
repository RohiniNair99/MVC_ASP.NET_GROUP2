using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskMeDTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Question { get; set; }
    }
}
