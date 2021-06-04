using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key] //primary key
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }
       //estos son datos de Category
       //Relacion Producto-Categoria (mucho a unos)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relacion Producto-Storage (uno a muchos)
        public ICollection<StorageEntity> Storages { get; set; }

    }
}
