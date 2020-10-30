using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryModels
{
    public class Category : FullAuditModel
    {
        [StringLength(InventoryModelsConstants.MAX_NAME_LENGTH)]
        public string Name { get; set; }
//Navigation Properties
        public virtual List<Item> Items { get; set; } = new List<Item>();
        public virtual CategoryColor CategoryColor { get; set; }
        public int? CategoryColorId { get; set; }
    }
}
