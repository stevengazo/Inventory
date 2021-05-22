using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WhereHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WhereHouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WhereHouseName { get; set; }
        [Required]
        [StringLength(600)]
        public string WhereHouseAddress { get; set; }
    }
}
