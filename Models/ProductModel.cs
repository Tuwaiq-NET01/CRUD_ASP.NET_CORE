using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_with_ASP.NET.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "It is required field!!")]
        public string Description { get; set; }
        [Required(ErrorMessage= "Please, insert a invalid value here ^_^")]
        public float Price { get; set; }
    }
}
