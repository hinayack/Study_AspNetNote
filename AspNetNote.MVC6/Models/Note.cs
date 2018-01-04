using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetNote.MVC6.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int Note_Num { get; set; }
        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required]
        public string Note_Title { get; set; }
        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required]
        public string Note_Contents { get; set; }
        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required]
        public int User_Num { get; set; }

        /// <summary>
        /// User 테이블 Join
        /// Virtual 레이지로딩(비동기 자료 처리 형태)로 메인을 먼저 가져오고 그 후에 User 테이블 정보를 로드 한다.
        /// </summary>
        [ForeignKey("User_Num")]
        public virtual User User { get; set; }
    }
}
