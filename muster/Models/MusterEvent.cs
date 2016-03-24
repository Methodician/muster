using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace muster.Models
{
    public class MusterEvent
    {
        public int Id { get; set; }
        public int CampId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Camp Camp { get; set; }
    }
}