using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS_Web.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        [Authorize]
        public ActionResult Profile()
        {
            return View(new CustomerTable().SelectCustomerByLogin(System.Web.HttpContext.Current.User.Identity.Name));
        }

        [HttpPost]
        public ActionResult Profile(string currentPassword, string newPassword, string repeatPassword)
        {
            if (newPassword != repeatPassword)
            {
                ViewBag.message = "Password don't match";
                return View(new CustomerTable().SelectCustomerByLogin(System.Web.HttpContext.Current.User.Identity.Name));
            }
            else
            {
                if (currentPassword ==
                    new CustomerAccountTable().CheckCurrentPassword(System.Web.HttpContext.Current.User.Identity.Name))
                {
                    int i = new CustomerAccountTable().ChangePassword(System.Web.HttpContext.Current.User.Identity.Name,
                        newPassword);
                    if (i == 1)
                    {
                        ViewBag.message = "Password was changed";
                        return View(new CustomerTable().SelectCustomerByLogin(System.Web.HttpContext.Current.User.Identity.Name));
                    }
                    else
                    {
                        ViewBag.message = "Something went wrong";
                        return View(new CustomerTable().SelectCustomerByLogin(System.Web.HttpContext.Current.User.Identity.Name));
                    }
                }
                else
                {
                    ViewBag.message = "Current password is wrong";
                    return View(new CustomerTable().SelectCustomerByLogin(System.Web.HttpContext.Current.User.Identity.Name));
                }
            }
        }
    }
}