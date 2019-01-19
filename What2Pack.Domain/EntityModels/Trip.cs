using System;
using System.Collections.Generic;

namespace What2Pack.Domain.EntityModels
{
    public class Trip
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<PackedItem> PackedItems { get; set; }
    }
}
