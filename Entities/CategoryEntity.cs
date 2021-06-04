using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        //le ponemos Key encima del atributo q sera llave primaria
        [Key]
        [StringLength(50)]   //tamano de 50
        public string CategoryId { get; set; }
        [Required]  //parametro obligatorio
        [StringLength(100)]
        public string CategoryName { get; set; }

        //una categoria tiene muchos productos (una a muchas)
        //una a muchas
        public ICollection<ProductEntity> Products { get; set; }
    }
}
