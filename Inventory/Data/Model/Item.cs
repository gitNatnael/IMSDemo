using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
   public class Item
    {
        [Key]
        public Guid ItemId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Item name should be more than 2")]
        public string ItemName { get; set; }
        [Required]
        public double Price { get; set; }

        public long Quantity { get; set; }
    }
}
