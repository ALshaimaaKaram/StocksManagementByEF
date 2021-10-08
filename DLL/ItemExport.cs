using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL
{
    public class ItemExport
    {
        public int ID { get; set; }
        public int QuantityOut { get; set; }
        public DateTime DateOut { get; set; }
        [ForeignKey("Item")]
        public virtual int ItemID { get; set; }
        public virtual Item Item { get; set; }
    }
}
