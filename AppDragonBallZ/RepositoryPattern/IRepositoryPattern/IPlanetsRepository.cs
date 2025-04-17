using AppDragonBallZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.RepositoryPattern.IRepositoryPattern
{
    public interface IPlanetsRepository
    {
        Task<Respuesta> Planets();
        Task<Respuesta> ObtenerPlanetaPorId(int PlanetaId);
        Task<Respuesta> ObtenerPlanetaPorNombre(string nombre);
    }
}
