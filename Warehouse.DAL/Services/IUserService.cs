using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Models;

namespace Warehouse.DAL.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
    }
}
