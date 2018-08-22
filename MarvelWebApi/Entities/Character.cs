using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelWebApi.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public IEnumerable<RoleEnum> Roles { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
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
