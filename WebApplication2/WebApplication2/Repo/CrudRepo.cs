using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Reflection;
namespace WebApplication2.Repo
{
    public class CrudRepo<TModel> : ICrudRepo<TModel> where TModel : class, new()
    {
        public virtual bool Add(TModel data)
        {
            using (EventMgmtSystemEntities ctx = new EventMgmtSystemEntities())
            {

               PropertyInfo prop= data.GetType().GetProperty("Id");
             int id= Convert.ToInt32(prop.GetValue(data));
                if (id>0)
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
                    ctx.Set<TModel>().Add(data);
                    int result = ctx.SaveChanges();
                    if (result > 0)
                        return true;
                    else
                        return false;

                }

            }
        }

        public TModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(TModel data)
        {
            throw new NotImplementedException();
        }
    }
}