using System;
using System.Collections.Generic;

namespace CoreEcommerceUserPanal.Models
{
    public partial class Feedbacks
    {
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string EmaidId { get; set; }
        public long PhoneNo { get; set; }
        public string Comment { get; set; }
    }
}
