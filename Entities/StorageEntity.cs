using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
        [Required]
        public int PartialQuantity { get; set; }

        /// Relation with ProductEntity
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        // Relaion With WareHouseEntity
        public string WareHouseId { get; set; }
        public WareHouseEntity WareHouse { get; set; }
        // Relation With InputOutputEntity
        public ICollection<InputOutputEntity> inputOutputs { get; set; }

    }
}
