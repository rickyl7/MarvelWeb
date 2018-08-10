using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelWeb.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public IEnumerable<RoleEnum> Roles { get; set; }

        public enum RoleEnum
        {
            Defense,
            Purge,
            Utility,
            AOE,
            Burst,
        }
    }
}
