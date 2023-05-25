﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Book.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order should be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
