using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Repo;

namespace WebApplication2.Service
{
    public class CrudService<TModel> : ICrudService<TModel> where TModel : class, new()
    {
        

        public bool Add(TModel data)
        {
            CrudRepo<TModel> _repo = new Repo.CrudRepo<TModel>();
            return _repo.Add(data);
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