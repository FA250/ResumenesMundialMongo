using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo
{
    public class ClaseAficionado
    {
        public ObjectId Id { get; set; }
        public String codigo{get;set;}
        public String contrasena{get;set;}
        public byte[] foto{get;set;}
        public bool mostrar_foto{get;set;}
        public String correo_electronico{get;set;}
        public bool mostrar_correo{get;set;}
        public bool borrado{get;set;}
        public DateTime fecha_borrado{get;set;}                            
    }
}
