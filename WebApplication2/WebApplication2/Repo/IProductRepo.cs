using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repo
{
    interface IProductRepo
    {
        bool Add(User_Type data);
        bool Update(User_Type data);
        User_Type Get(int id);
        List<User_Type> GetAll();
    }
}
