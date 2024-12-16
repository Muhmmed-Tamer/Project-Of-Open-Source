using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Open_Source_Project.ViewModels
{
    public class ApplicationLoginUser
    {
        [EmailAddress]
        public string Email {  get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
