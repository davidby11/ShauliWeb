using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShauliWeb.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentTitle { get; set; }
        public string WriterName { get; set; }
        public string URL { get; set; }
        public string Content { get; set; }
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
