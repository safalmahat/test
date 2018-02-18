using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Service
{
    interface ICrudService<TModel> where TModel:class,new()
    {
        bool Add(TModel data);
        bool Update(TModel data);
        TModel Get(int id);
        List<TModel> GetAll();
    }
}
