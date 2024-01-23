using System.Collections.Generic;
using BCA_III_jan_2024.Models;
using BCA_III_jan_2024.Providers;
using Dapper;

namespace BCA_III_jan_2024.Repository
{
    public class UserRepository
    {
        public static List<AppUser> GetUsers()
        {
            using (var conn = ConnectionProvider.GetConnection())
            {
                var userListQuery = @"
select * from app_user
";
                var userList = conn.Query<AppUser>(userListQuery, new
                {

                });
                return userList.AsList();
            }
        }
    }
}