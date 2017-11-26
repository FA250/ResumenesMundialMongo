using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenMundialMongo.BD
{
    class ClaseMD
    {
        ClaseConexion conexion = new ClaseConexion();
        //---------------- Seleccionar partidos ----------------
        public ArrayList Select_Todos_Partidos()
        {
            ArrayList tuplas = new ArrayList();
            ArrayList atributos = new ArrayList();
            conexion.parametro("", "", "", "");
            conexion.inicializa();
            String consulta;
            System.Data.OleDb.OleDbDataReader Contenedor;//crea un contenedor de la base de datos


            consulta = "select VP1.numero_partido, Equipo_1,Equipo_2 from (select numero_partido,nombre_pais as Equipo_1 from VISTAPARTIDOS join equipo on VistaPartidos.Equipo_1=equipo.COD_PAIS) VP1 JOIN (select numero_partido,nombre_pais as Equipo_2 from VISTAPARTIDOS join equipo on VistaPartidos.Equipo_2=equipo.COD_PAIS) VP2 on VP1.numero_partido=VP2.numero_partido";

            conexion.annadir_consulta(consulta);
            //conexion.annadir_parametro(confederacion, 2);

            Contenedor = conexion.busca(); //BUSCA EJECUTA EL SQL QUE LE DIMOS ARRIBA A LA VARIABLE CONEXION

            //Buscar los campos solicitados
            while (Contenedor.Read())
            {
                atributos.Add(Contenedor["numero_partido"].ToString());
                atributos.Add(Contenedor["Equipo_1"].ToString().Split(' ')[0]);
                atributos.Add(Contenedor["Equipo_2"].ToString());

                tuplas.Add(atributos);
                atributos = new ArrayList();

            }//CONTENEDOR READ

            Contenedor.Close();//Cierra contenedor con los datos seleccionados


            return tuplas;//devuelve los datos necesarios
        }
    }
}
