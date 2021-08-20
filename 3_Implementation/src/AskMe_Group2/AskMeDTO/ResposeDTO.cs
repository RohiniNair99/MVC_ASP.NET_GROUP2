using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskMeDTO
{
    public class ResposeDTO
    {
        public int ResponseId { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public Nullable<int> Upvote { get; set; }
        public string Response { get; set; }

    }
}
