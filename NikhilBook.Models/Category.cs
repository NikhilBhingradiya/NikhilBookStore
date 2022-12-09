using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace NikhilBook.Models
{
    public class Category
    {
        public object id;
        public string ImageUrl;
        public string Title;

        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
            [Required]
            [MaxLength(50)]

            public string Name {get; set;}
     }
}
