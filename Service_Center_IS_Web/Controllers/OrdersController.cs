using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;
using Service_Center_IS.Database;
using Service_Center_IS.Database.dao_sqls;

namespace Service_Center_IS_Web.Controllers
{
    public class OrdersController : Controller
    {
        private int _orderPrice;

        // GET: Orders
        [Authorize]
        [HttpGet]
        [Route("MainPage/{login}")]
        public ActionResult MainPage()
        {
            return View(OrderTable.SelectOrderByLogin(System.Web.HttpContext.Current.User.Identity.Name));
        }
        [Authorize]
        [ActionName("NewOrder")]
        public ActionResult MainPage(string type, string company, string model, string defect, int price)
        {
            int i = OrderTable.CreateNewOrderFromWeb(type, company, model, defect, price, System.Web.HttpContext.Current.User.Identity.Name.ToLower());
            return View(i);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Pay(int id, int price, string status)
        {
            Session["id"] = id;
            Session["price"] = price;
            Session["status"] = status;
            Order order = new Order()
            {
                Oid = id,
                Price = price,
                Status = status,
            };
            return View(order);
        }

        [HttpPost]
        public ActionResult Pay(Order order)
        {
            if (int.Parse(Session["price"].ToString()) > order.Price)
            {
                Order orderBack = new Order
                {
                    Oid = int.Parse(Session["id"].ToString()),
                    Price = int.Parse(Session["price"].ToString()),
                    Status = Session["status"].ToString()
                };
                ViewBag.message = "Not enough money";
                return View(orderBack);
            }
            else
            {
                int i = OrderTable.PayOrder(int.Parse(Session["id"].ToString()));
                if (i == -1)
                {
                    Order orderBack = new Order
                    {
                        Oid = int.Parse(Session["id"].ToString()),
                        Price = int.Parse(Session["price"].ToString()),
                        Status = Session["status"].ToString()
                    };
                    ViewBag.message = "You already payed this order";
                    return View(orderBack);

                }
                else
                {
                    return RedirectToAction("MainPage", "Orders", new { login = System.Web.HttpContext.Current.User.Identity.Name });
                }
            }

        }

        [Authorize]
        public ActionResult CountOrderPrice()
        {
            Session.Clear();
            MongoCRUD db = new MongoCRUD("DeviceList");
            var resc = db.LoadRecords<MongoCRUD.MongoDevice>("Devices");
            Collection<string> typeList = new Collection<string>();
            foreach (var deice in resc)
            {
                typeList.Add(deice.Type);
            }
            SelectList selectListType = new SelectList(typeList.Distinct().ToList());
            ViewBag.type = selectListType.Items;

            return View();
        }

        [HttpPost]
        public ActionResult CountOrderPrice(string type, string company, string model, string defect)
        {
            MongoCRUD db = new MongoCRUD("DeviceList");
            var resc = db.LoadRecords<MongoCRUD.MongoDevice>("Devices");
            Collection<string> companyList = new Collection<string>();
            SelectList list = new SelectList(companyList.Distinct().ToList());
            ViewBag.type = type;
            Session["typeName"] = type;
            if (type != "Type" && company == "Company" && model == "Model" && defect == "Defect")
            {
                foreach (var device in resc)
                {
                    if (device.Type == type)
                    {
                        companyList.Add(device.Company);
                    }
                }
                list = new SelectList(companyList.Distinct().ToList());
                ViewBag.company = list.Items;
            }

            if (type != "Type" && company != "Company" && model == "Model" && defect == "Defect")
            {
                foreach (var device in resc)
                {
                    if (device.Type == type && device.Company == company)
                    {
                        companyList.Add(device.Model);
                    }
                }
                list = new SelectList(companyList.Distinct().ToList());
                ViewBag.model = list.Items;
            }

            if (type != "Type" && company != "Company" && model != "Model" && defect == "Defect")
            {
                foreach (var device in resc)
                {
                    if (device.Type == type && device.Company == company && device.Model == model)
                    {
                        companyList.Add(device.Defect);
                    }
                }

                list = new SelectList(companyList.Distinct().ToList());
                ViewBag.defect = list.Items;
            }

            if (type != "Type" && company != "Company" && model != "Model" && defect != "Defect")
            {
                foreach (var device in resc)
                {
                    if (device.Type == type && device.Company == company && device.Model == model && device.Defect == defect)
                    {
                        ViewBag.price = device.Price;
                    }
                }
            }

            if (ViewBag.company == null)
            {
                ViewBag.company = company; 
                Session["companyName"] = company;
            }
            if (ViewBag.model == null)
            {
                ViewBag.model = model;
                Session["modelName"] = model;
            }
            if (ViewBag.defect == null)
            {
                ViewBag.defect = defect;
                Session["defectName"] = defect;
            }

            return View();
        }
        //[HttpPost]
        //public ActionResult CountOrderPrice(string type, string company, string model, string defect)
        //{
        //    MongoCRUD db = new MongoCRUD("DeviceList");
        //    var resc = db.LoadRecords<MongoCRUD.MongoDevice>("Devices");
        //    Collection<string> companyList = new Collection<string>();
        //    ViewBag.type = type;
        //    
        //    int huj;
        //    try
        //    {
        //        huj = Int32.Parse(Session["companyPicked"].ToString());
        //    }
        //    catch (Exception e)
        //    {
        //        huj = 0;
        //    }
        //    if (company != null && huj != 1 && company == "Company")
        //    {
        //        ViewBag.company = company;
        //        Session["companyName"] = company;
        //        foreach (var device in resc)
        //        {
        //            if (device.Type == type)
        //            {
        //                companyList.Add(device.Company);
        //            }
        //        }
        //        SelectList list = new SelectList(companyList.Distinct().ToList());
        //        ViewBag.company = list.Items;
        //    }
        //    try
        //    {
        //        huj = Int32.Parse(Session["modelPicked"].ToString());
        //    }
        //    catch (Exception e)
        //    {
        //        huj = 0;
        //    }

        //    if (model != null && huj == 1 && company != "Company")
        //    {
        //        ViewBag.model = model;
        //        Session["modelName"] = model;
        //        foreach (var device in resc)
        //        {
        //            if (device.Company == company)
        //            {
        //                companyList.Add(device.Model);
        //            }
        //        }
        //        SelectList list = new SelectList(companyList.Distinct().ToList());
        //        ViewBag.model = list.Items;
        //    }

        //    try
        //    {
        //        huj = Int32.Parse(Session["defectPicked"].ToString());
        //    }
        //    catch (Exception e)
        //    {
        //        huj = 0;
        //    }
        //    if (defect != null && huj == 1 && defect == "Defect")
        //    {
        //        ViewBag.defect = defect;
        //        Session["defectName"] = defect;
        //        foreach (var device in resc)
        //        {
        //            if (device.Model == model)
        //            {
        //                companyList.Add(device.Defect);
        //            }
        //        }
        //        SelectList list = new SelectList(companyList.Distinct().ToList());
        //        ViewBag.defect = list.Items;
        //    }



        //    return View();

        //}

    }
}