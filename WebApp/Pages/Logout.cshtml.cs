using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Model;

namespace WebApp.Pages
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<AppUser> signInManager;

        public LogoutModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("Login");
            
        }
        public  IActionResult OnPostDontLogoutAsync()
        {
            return RedirectToPage("Index");

        }



    }
}
