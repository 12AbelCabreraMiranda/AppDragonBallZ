using AppDragonBallZ.Model;
using AppDragonBallZ.RepositoryPattern.IRepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_DragonBallZ.RepositoryPattern
{
    public class PlanetsRepository : IPlanetsRepository
    {
        public Task<Respuesta> ObtenerPlanetaPorId(int PlanetaId)
        {
            throw new NotImplementedException();
        }

        public Task<Respuesta> ObtenerPlanetaPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Task<Respuesta> Planets()
        {
            throw new NotImplementedException();
        }
    }
}
