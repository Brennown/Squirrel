using System.ComponentModel.DataAnnotations;

namespace SquirrelUi.Models.Domain
{
    public class Account
    {
        [Required(ErrorMessage = "Username is obrigatory")]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is obrigatory")]
        [Display(Name ="Passord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
