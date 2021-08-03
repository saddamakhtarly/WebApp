using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.Model;
using WebApp.ViewModels;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<AppUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        
        public void OnGet()
        {
           
        }
        public LoginModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl=null)
        {
            if (ModelState.IsValid)
            {
               
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe,false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl=="/")
                    {
                        return RedirectToPage("Index");

                    }
                    else
                    {
                        return RedirectToPage(returnUrl);

                    }
                }
                
                    ModelState.AddModelError("", "Username or Password incorrect");

                
            }
            return Page();
        }


    }
}
