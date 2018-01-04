using System.ComponentModel.DataAnnotations;

namespace AspNetNote.MVC6.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="사용자 ID를 입력해주세요.")]
        public string User_Id { get; set; }

        [Required(ErrorMessage ="사용자 패스워드를 입력해주세요.")]
        public string User_Password { get; set; }
    }
}
