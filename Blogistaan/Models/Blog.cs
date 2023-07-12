using System.ComponentModel.DataAnnotations;
using System;

namespace Blogistaan.Models
{
    
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Short Description field is required.")]
        [StringLength(500)]
        public string ShortDescription { get; set; }


        [Required(ErrorMessage = "The Content field is required.")]
        [StringLength(5000)]
        public string Content { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        public int Author { get; set; }
    }

}