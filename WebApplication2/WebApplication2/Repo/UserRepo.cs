using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repo
{
    public class UserRepo :CrudRepo<User_Info>
    {
        public override bool Add(User_Info data)
        {
            data.created_on = DateTime.Now;
            return base.Add(data);
        }
    }
}