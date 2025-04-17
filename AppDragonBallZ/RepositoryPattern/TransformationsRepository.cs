using AppDragonBallZ.Model;
using AppDragonBallZ.RepositoryPattern.IRepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_DragonBallZ.RepositoryPattern
{
    public class TransformationsRepository : ITransformationsRepository
    {
        public Task<Respuesta> ObtenerTransformationPorId(int TransformationId)
        {
            throw new NotImplementedException();
        }

        public Task<Respuesta> Transformations()
        {
            throw new NotImplementedException();
        }
    }
}
