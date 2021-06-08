using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_with_ASP.NET.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage="It is a required field")]
        public float Price { get; set; }
    }
}
