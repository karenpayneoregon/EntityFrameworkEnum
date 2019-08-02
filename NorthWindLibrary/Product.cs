using NorthWindLibrary.Classes;

namespace NorthWindLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        public CategoriesName CategoryID { get; set; }
        public virtual Category Category { get; set; }
        /// <summary>
        /// Added for use as Display member in a form control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ProductName;
        }
    }
}
