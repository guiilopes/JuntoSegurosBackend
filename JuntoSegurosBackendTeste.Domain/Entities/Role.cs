using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace JuntoSegurosBackendTeste.Domain.Entities
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}
