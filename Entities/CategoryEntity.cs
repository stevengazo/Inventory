using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{   /// <summary>
    /// Entidad categoria
    /// </summary>
    public class CategoryEntity
    {
        [Key]  
        [StringLength(50)]
        public string CategoryId { set; get;}

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        
    }
}
