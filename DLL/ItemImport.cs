using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL
{
    public class ItemImport
    {
        public int ID { get; set; }
        public int QuantityIn { get; set; }
        public DateTime DateIn { get; set; }
        [ForeignKey("Item")]
        public virtual int ItemID { get; set; }
        public virtual Item Item { get; set; }
    }
}
