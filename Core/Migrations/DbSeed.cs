using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Migrations
{
    public class DbSeed
    {
        public static void InsertBaseRoles()
        {
            using (var context = new ChattingContext())
            {
                var roles = new List<Role>();
                roles.Add(new Role { RoleName = Constants.Roles.APPADMIN_ROLE });
                roles.Add(new Role { RoleName = Constants.Roles.APPEDITOR_ROLE });
                context.Roles.AddRange(roles);
                context.SaveChanges();
            }
        }
    }
}
