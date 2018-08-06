using MarvelWebApi.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelWebApi.Repositories
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetAll();
    }

    public class CharacterRepository : ICharacterRepository
    {
        public CharacterRepository()
        {
            _characters = JsonConvert.DeserializeObject<IEnumerable<Character>>(File.ReadAllText("characters.json"));
        }

        private IEnumerable<Character> _characters;

        public IEnumerable<Character> GetAll()
        {
            return _characters;
        }
    }
}
