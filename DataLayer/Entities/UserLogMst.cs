using System;
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public partial class UserLogMst
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Request { get; set; } = null!;
        public DateTime RequestDate { get; set; }
        public string Response { get; set; } = null!;
        public DateTime ResponseDate { get; set; }
    }
}
