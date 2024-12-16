using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Open_Source_Project.ViewModels
{
    public class ApplicationRegisterUser
    {
        [DisplayName("First Name")]
        public string FirstName {  get; set; }
        [DisplayName("Last Name")]
        public string LastName {  get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password") , DataType(DataType.Password) ,Compare("Password")]
        public string ConfirmPassword { get; set; }
        [DisplayName("Phone Number") , Phone]
        public string PhoneNumber { get; set; }
    }
}
