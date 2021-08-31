using System;
using System.Collections.Generic;

#nullable disable

namespace logproje.Models
{
    public partial class Logtb
    {
        public int Int { get; set; }
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LogType { get; set; }
    }
}
