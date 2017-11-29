
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.Clases
{
    class ClaseComentario
    {
        public ObjectId Id { get; set; }
        public int numero_partido { get; set; }
        public int numero_comentario { get; set; }
        public String aficionado { get; set; }
        public DateTime fecha { get; set; }
        public String mensaje { get; set; }
        public List<ClaseComentario> hilo { get; set; }
    }
}
