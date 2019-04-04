using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerceUserPanal.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string EmaidId { get; set; }
        public long PhoneNo { get; set; }
        public string Comment { get; set; }

    }
}
