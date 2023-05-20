using System;
using System.Collections.Generic;

#nullable disable

namespace SiriusApi.Models
{
    public partial class TbVendor
    {
        public TbVendor()
        {
            TbPlants = new HashSet<TbPlant>();
        }

        public int IdVenditori { get; set; }
        public string TxVendors { get; set; }
        public string TxDownTimeClass { get; set; }

        public virtual ICollection<TbPlant> TbPlants { get; set; }
    }
}
