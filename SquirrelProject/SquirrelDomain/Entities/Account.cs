using System.ComponentModel.DataAnnotations;

namespace SquirrelDomain.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        [Required(ErrorMessage = "Username is obrigatory")]
        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is obrigatory")]
        [Display(Name = "Passord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
