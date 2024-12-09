using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingEntityFrameworkCodeFirst.Entities
{
    public class Product
    {
        //Scalar Properties
        [Key] //primary key applied
        [StringLength(5)]
        [Column(TypeName ="char")]
        public string Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
        public int? Price { get; set; } //null constraint is applied
        public int? Stock { get; set; }

    }
}