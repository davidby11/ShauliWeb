using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShauliWeb.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string CommentText { get; set; }
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
