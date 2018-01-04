using Microsoft.AspNetCore.Mvc;
using AspNetNote.MVC6.Models;
using AspNetNote.MVC6.DataContext;
using System.Linq;
using AspNetNote.MVC6.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetNote.MVC6.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 로그인 View;
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    //linq - 메서드 체인닝으로 처리 함.
                    //var user = db.Users.FirstOrDefault(u => u.User_Id == model.User_Id && u.User_Password == model.User_Password);
                    var user = db.Users.FirstOrDefault(u => u.User_Id.Equals(model.User_Id) && u.User_Password.Equals(model.User_Password));

                    if (user != null)
                    {
                        //Login성공
                        return RedirectToAction("LoginSuccess", "Home"); //로그인 성공 페이지로 이동
                    } 
                }
                //Login에 실패
                ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
            }
            return View(model);
        }

        /// <summary>
        /// 회원가입 view
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }



        /// <summary>
        /// 회원가입전송 Post
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model) {
            //유효성 체크
            if (ModelState.IsValid) {

                /*
                 * java에서는 try{}catch{} 으로 처리
                 * c#에서는 using문을 사용함
                 * using에서 db설정 후 해당 구문을 빠져나가면 db가 자동으로 닫히게 됨.
                 */
                using (var db = new AspnetNoteDbContext())
                {
                    db.Users.Add(model);    //메모리에 올라감
                    db.SaveChanges();       //sql에 업로드

                    return RedirectToAction("index", "Home");
                }
            }
            return View(model);
        }
    }
}
