using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Business.Abstract;
using TeknolojikAletSatisSitesi.WebUI.Identity;
using TeknolojikAletSatisSitesi.WebUI.Models;

namespace TeknolojikAletSatisSitesi.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ICartService _cartService;

        public AccountController(ICartService cartService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _cartService = cartService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // generate token
                // send email

                /*---------- Osman bu yorum satırına sen baktıktan sonra sileriz
                _cartService.InitializeCart(user.Id); confirmEmail fonksiyonuna yazıyor bu satırı bizde olmadığı için buraya yazmamız gerekiyor!!!!!!!*/
                _cartService.InitializeCart(user.Id);

                return RedirectToAction("Login", "Account");
            }


            ModelState.AddModelError("", "Bilinmeyen hata oluştu lütfen tekrar deneyiniz.");
            return View(model);
        }


        //////
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl = null)
        {
            returnUrl = returnUrl ?? "~/";

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu kullanıcı ile daha önce hesap oluşturulmamış.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, true, false);

            if (result.Succeeded)
            {
                return Redirect(returnUrl);
            }
            ModelState.AddModelError("", "Kullanıcı adı ve ya parola yanlış");
            return View();          
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public IActionResult Accessdenied()
        {
            return View();
        }
    }
}
