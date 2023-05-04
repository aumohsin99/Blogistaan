using System.ComponentModel.DataAnnotations;
using System;

namespace Blogistaan.Models
{

    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(5000)]
        public string Content { get; set; }

        [Required]
        public DateTime DatePublished { get; set; }

        public string Author { get; set; }
    }


}