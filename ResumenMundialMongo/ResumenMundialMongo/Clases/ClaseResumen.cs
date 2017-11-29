using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.Clases
{
    class ClaseResumen
    {
        public ObjectId Id { get; set; }
        public int numero_partido { get; set; }
        public String mensaje { get; set; }
        public String equipos { get; set; }
        public List<byte[]> videos { get; set; }

    }
}
