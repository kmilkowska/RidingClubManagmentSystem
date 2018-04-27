using System.ComponentModel.DataAnnotations;

namespace RidingClubMS.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "{0} musi mieć minumim {2} i maksymalnie {1} znaków.", MinimumLength = 2)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "{0} musi mieć minumim {2} i maksymalnie {1} znaków.", MinimumLength = 2)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Role { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi mieć minumim {2} i maksymalnie {1} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasło i potwiedzenie hasła różnią się.")]
        public string ConfirmPassword { get; set; }

     
    }
}
