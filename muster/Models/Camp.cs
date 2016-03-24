using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace muster.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Mustering { get; set; }
        public MusterEvent ActiveMuster { get; set; }
        public ICollection<MusterEvent> Musters { get; set; }

        public Camp() { Musters = new List<MusterEvent>();}
    }
}