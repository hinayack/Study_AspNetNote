using System.ComponentModel.DataAnnotations;

namespace AspNetNote.MVC6.Models
{
    public class User
    {
        /// <summary>
        /// 사용자번호[pk]
        /// </summary>
        [Key]   //PK설정
        public int User_Num { get; set; }
        /// <summary>
        /// 사용자ID
        /// </summary>
        [Required(ErrorMessage ="사용자 아이디를 입력해주세요.")]
        public string User_Id { get; set; }
        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage = "사용자 이름을 입력해주세요.")]
        public string User_Name { get; set; }
        /// <summary>
        /// 사용자 패스워드
        /// </summary>
        [Required(ErrorMessage = "사용자 비밀번호를 입력해주세요.")]
        public string User_Password { get; set; }
    }
}
