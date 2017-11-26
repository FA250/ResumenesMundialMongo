using MongoDB.Driver;
using MongoDB.Driver.Linq;  
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.BD
{
    class ManejoMongoDB
    {
        static String connectionstr="mongodb://localhost";
        static MongoClient client = new MongoClient(connectionstr);

        static IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

        static ClaseEncriptacion EC=new ClaseEncriptacion();
        Object Aficionados = new BsonDocument
        {
            { "codigo" , "Administrador"},
            { "contrasena", EC.DecryptKey("Administrador").ToString()},
            { "cuisine", "Italian" },
            { "grades", new BsonArray
                {
                    new BsonDocument
                    {
                        { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                        { "grade", "A" },
                        { "score", 11 }
                    },
                    new BsonDocument
                    {
                        { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                        { "grade", "B" },
                        { "score", 17 }
                    }
                }
            },
            { "name", "Vella" },
            { "restaurant_id", "41704620" }
        };

        Object collection = DB.GetCollection<BsonDocument>("");

        //collection.InsertOneAsync(document);
    }
}
