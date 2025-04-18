using AppDragonBallZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.RepositoryPattern.IRepositoryPattern
{
    public interface ICharactersRepository
    {
        Task<Respuesta> Characters(string uriApi);
        Task<Respuesta> GetCharacterById(long characterId);
        Task<Respuesta> GetCharacterByName(string name);
        
    }
}
