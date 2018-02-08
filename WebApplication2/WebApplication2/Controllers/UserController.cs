using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult  GetAllUsers()
        {
            List<User_Info> list_users = new List<Models.User_Info>();
            EventMgmtSystemEntities ctx = new EventMgmtSystemEntities();
            ctx.Configuration.ProxyCreationEnabled = false;
            //IEnumerable<dynamic> data=  ctx.User_Info.Select(r => new {
            //    Id=r.Id,
            //       First_Name = r.First_Name,
            //       Last_Name=r.Last_Name,
            //       Address=r.Address,
            //       Email=r.Email,
            //       Contact=r.Contact_Number
            //   }).ToList();
            list_users = ctx.User_Info.ToList();
            return Json(list_users, JsonRequestBehavior.AllowGet);
        }
        public bool Delete(int id)
        {
            using (EventMgmtSystemEntities ctx = new Models.EventMgmtSystemEntities())
            {
                ctx.User_Info.Remove(ctx.User_Info.Find(id));
                int result = ctx.SaveChanges();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool Add(User_Info data)
        {
            using (EventMgmtSystemEntities ctx = new EventMgmtSystemEntities())
            {
                ctx.User_Info.Add(data);
                int result = ctx.SaveChanges();
                if (result > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}