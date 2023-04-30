using System.ComponentModel.DataAnnotations;


namespace Blogistaan.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        //[Required]
        //[StringLength(100)]
        //public string Email { get; set; }
    }

}