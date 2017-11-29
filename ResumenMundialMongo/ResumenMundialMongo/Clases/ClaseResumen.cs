﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.Clases
{
    public class ClaseResumen
    {
        public ObjectId Id { get; set; }
        public String numero_partido { get; set; }
        public String mensaje { get; set; }
        public String equipos { get; set; }
        public List<ClaseVideo> videos { get; set; }

    }
}
