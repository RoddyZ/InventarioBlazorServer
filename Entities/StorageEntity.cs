using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        
        //relacion Storage-product (muchos a uno)
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relacion: Con Bodegas(WhereHouse) mucho a uno
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relacion: Con movimientos (InOut) una a muchas
        public ICollection<InOutEntity> InOutputs { get; set; }

    }
}
