using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Data;
using Warehouse.DAL.Helpers;
using Warehouse.DAL.Models;

namespace Warehouse.DAL.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly WarehouseContext _warehouseContext;

        public UserService (IOptions<AppSettings> appSettings, WarehouseContext warehouseContext)
        {
            _appSettings = appSettings.Value;
            _warehouseContext = warehouseContext;
        }

        public User Authenticate(string email, string password)
        {
            var user = _warehouseContext.Users.SingleOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserID", user.Id.ToString()),
                    new Claim("Email", user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }
    }
}
