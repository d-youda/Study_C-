using System.ComponentModel.DataAnnotations;

namespace NetCore.Web.Models
{
    public class LoginInfo
    {
        [Required(ErrorMessage ="사용자 아이디를 입력하세요")]//필수항목 입력 없으면 에러 메세지 출력
        [MinLength(6,ErrorMessage ="사용자 아이디는 최소 6자 이상 입력하세요")]//최소  
        [Display(Name ="사용자 아이디")]
        public string Userid {  get; set; }

        [Required(ErrorMessage ="비밀번호를 입력하세요")]
        [MinLength(6, ErrorMessage = "비밀번호는 최소 6자 이상 입력하세요")]//최소
        [Display(Name = "비밀번호")]
        public string Password { get; set; }
    }
}
