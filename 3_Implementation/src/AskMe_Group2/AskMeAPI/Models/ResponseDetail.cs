using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMeAPI.Models
{
    public class ResponseDetail
    {
        public int ResponseId { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public Nullable<int> Upvote { get; set; }
        public string Response { get; set; }
    }
}