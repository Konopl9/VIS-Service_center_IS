using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult MainPage()
        {
            return View();

        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Login")]
        public ActionResult Login(CustomerAccount customerAccount, string returnUrl)
        {
            CustomerAccount customer = new CustomerAccount
            {
                Login = customerAccount.Login,
                Password = customerAccount.Password
            };
            // поиск пользователя в бд
            int isValid = CustomerAccountTable.SignUp(customer);
            if (isValid != 0)
            {
                FormsAuthentication.SetAuthCookie(customerAccount.Login, true);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else 
                {
                    return RedirectToAction("MainPage", "Orders");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }
        }

        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Customer customerData)
        {
            Customer customer = new Customer
            {
                Name = customerData.Name,
                Surname = customerData.Surname,
                DateOfBirthday = customerData.DateOfBirthday,
                Phone = customerData.Phone,
                Email = customerData.Email
            };
            int customerRowAdded = new CustomerTable().Create(customer);
            if (customerRowAdded == 1)
            {
                int accountRow = CustomerAccountTable.AddCustomerAccount();
                if (accountRow == 1)
                {
                   return RedirectToAction("Login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User with this login already exists.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid registration data");
            }

            return View(customerData);

        }
    }
}