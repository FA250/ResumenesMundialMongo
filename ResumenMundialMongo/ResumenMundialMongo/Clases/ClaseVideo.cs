using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.Clases
{
    public class ClaseVideo
    {
        public ObjectId Id { get; set; }
        public int codigoV { get; set; }
        public byte[] video { get; set; }
    }
}
