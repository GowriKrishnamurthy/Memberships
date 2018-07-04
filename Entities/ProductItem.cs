using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("ProductItem")]
    public class ProductItem
    {
        // Composite primary keys
        [Required]
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int ItemId { get; set; }

        // Not mapped - variables present in the class but not added to the DB
        [NotMapped]
        public int OldProductId { get; set; }
        [NotMapped]
        public int OldItemId { get; set; }

    }
}