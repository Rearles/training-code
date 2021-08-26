using System;
using System.Collections.Generic;

#nullable disable

namespace NoteTakingApp.DataAccess.Entities
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
