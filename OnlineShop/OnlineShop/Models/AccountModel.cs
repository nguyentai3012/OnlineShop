using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string username, string password)
        {
            var sqlParams = new[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };
            var res = context.Database.SqlQuery<bool>("Login_procedure @Username,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}