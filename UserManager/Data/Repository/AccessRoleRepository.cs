﻿using UserManager.Data.Model;

namespace UserManager.Data.Repository
{
    public class AccessRoleRepository : IAccessRoleRepository
    {
        ApplicationDbContext _context;

        public AccessRoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public AccessRole? GetAccessRoleById(int id)
        {
            return _context.AccessRoles.SingleOrDefault(r => r.AccessRoleId == id);
        }

        public List<AccessRole> GetAllAccessRole()
        {
            return _context.AccessRoles.ToList();
        }
    }
}
