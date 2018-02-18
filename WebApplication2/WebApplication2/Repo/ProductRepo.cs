using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repo
{
    public class ProductRepo : IProductRepo
    {
        public bool Add(User_Type data)
        {
            using (EventMgmtSystemEntities ctx = new EventMgmtSystemEntities())
            {
                if (data.Id > 0)
                {
                    ctx.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    int result = ctx.SaveChanges();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    ctx.User_Type.Add(data);
                    int result = ctx.SaveChanges();
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public User_Type Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User_Type> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(User_Type data)
        {
            throw new NotImplementedException();
        }
    }
}