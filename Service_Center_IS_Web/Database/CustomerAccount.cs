using System.ComponentModel.DataAnnotations;

namespace Service_Center_IS.Database
{
    public class CustomerAccount
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(16, ErrorMessage = "Too short login! Hint - name, surname", MinimumLength = 3)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(30, ErrorMessage = "Too short password", MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public int CustomerUid { get; set; }
    }
}