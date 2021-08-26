using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Tags { get; set; }

        public int WordCount
        {
            get
            {
                var delimiters = new char[] { ' ', '\r', '\n' };
                return Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }
    }
}
