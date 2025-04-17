using AppDragonBallZ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.RepositoryPattern.IRepositoryPattern
{
    public interface ITransformationsRepository
    {
        Task<Respuesta> Transformations();
        Task<Respuesta> ObtenerTransformationPorId(int TransformationId);
      
    }
}
