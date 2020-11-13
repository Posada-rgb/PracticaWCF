using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRACTICAWCF.scrips
{
    public class Peliculas
    {

        //                          ===== EXPLICACIÓN 1 =====

        //EN ESTA HOJA TENEMOS LAS PROPIEDADES DEL OBJETO QUE VAMOS A USAR. 
          //ESTABLECEMOS UNA CLASE PELICULAS.
            //Una pelicula tiene ciertos atributos que deben visualizarse, en base a este
              //objeto estaremos trabajando. 
        
        int                   id;
        string            nombre;
        string            genero;
        string          duracion;
        string          director;
        string  fecha_de_estreno;

        //                          ===== EXPLICACIÓN 2 =====
        
        //Aquí utilizaremos indirectamente los valores, entonces tenemos que 
          //mandar a llamar el id de la pelicula, su nombre etc, 
           //get nos regresa un valor establecido
            //set establece uno 
             //esto nos será útil para los procesos requeridos


        public int id_peliculas {  
            
            get { return        id; }
            
            set { id     =   value; }

        }


        public string nombre_peliculas {
            
            get { return    nombre; }
            
            set { nombre  =  value; }

        }
        public string genero_pelicula {

            get { return    genero; }

            set { genero  =  value; }

        }

        public string durancion_pelicula {

            get { return     duracion; }
            set { duracion =    value; }
        }

        public string director_pelicula {

            get { return    director; }

            set { director =   value; }

        }

        public string fecha_estreno_peli
        {
            get { return  fecha_de_estreno; }

            set { fecha_de_estreno = value; }

        }
    }
}