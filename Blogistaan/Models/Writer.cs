using System.ComponentModel.DataAnnotations;


namespace Blogistaan.Models
{
    public class Writer
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Username is required")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50)]
        public string Password { get; set; }


    }

}