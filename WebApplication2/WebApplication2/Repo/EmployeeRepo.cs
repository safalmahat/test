using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using WebApplication2.Service;
namespace WebApplication2.Repo
{
    public class EmployeeRepo:CrudRepo<Employee_Info>
    {
    }
    public class EmployeeService :CrudService<Employee_Info>
    {
    }
}