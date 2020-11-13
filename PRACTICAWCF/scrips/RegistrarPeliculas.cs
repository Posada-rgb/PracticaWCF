using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRACTICAWCF.scrips
{
    public class RegistrarPeliculas
    {

        //           ====== EXPLICACION DE METODOS ======

            //Esto nos sirve para consultar y crear métodos
                //Por ejemplo, en registrar, decimos que vamos a crear una nueva pelicula 
                  //utilizando nuestro objeto, usando un id, genero, etc ya establecido
                    //El metodo Ver nos ayuda a insertar se insertan los datos manualmente mientras se compile el programa
                      //el tercer metodo solamente devuelve un mensaje tipo string 
        public Peliculas registrar() {

            Peliculas nueva_peli = new Peliculas();

                nueva_peli.id_peliculas         =                           1;
                nueva_peli.genero_pelicula      =                    "terror";
                nueva_peli.director_pelicula    =              "angel posada";
                nueva_peli.durancion_pelicula   =     "1 hora con 50 minutos";
                nueva_peli.fecha_estreno_peli   =                "02/12/2012";
                nueva_peli.nombre_peliculas     =     "el entierro prohibido";

            return nueva_peli;

        }

        public Peliculas ver(Peliculas pelicula) {

            return pelicula;

        }

        public string _3ermetodo() {

            return "este es el tercer metodo";

        }
    }
}