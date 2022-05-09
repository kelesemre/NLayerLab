using NLayerLab.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerLab.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        ICollection<Article> Articles { get; set; }
    }
}
