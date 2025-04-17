using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model
{
    public class Respuesta
    {
        public bool Resultado { get; set; }   
        public string Mensaje { get; set; }        
        public Exception Error { get; set; }
        public object Data { get; set; }
        public DataSet DataSet { get; set; }
    }
}
