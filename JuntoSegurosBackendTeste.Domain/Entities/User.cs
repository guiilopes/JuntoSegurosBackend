using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace JuntoSegurosBackendTeste.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public List<UserRole> UserRoles { get; set; }

        public string FullName { get; set; }
    }
}
