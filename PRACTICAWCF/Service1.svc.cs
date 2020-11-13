using PRACTICAWCF.scrips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PRACTICAWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        //          ==== EXPLICACION ====
            
            //Aqui solamente se trascriben todos los datos de los procedimientos  

        RegistrarPeliculas datos = new RegistrarPeliculas();
        public Peliculas Registrar()
        {
            return datos.registrar();
        }

        public Peliculas ver(Peliculas pelicula)
        {
            return datos.ver(pelicula);
        }

        public string _3ermetodo()
        {
            return datos._3ermetodo();
        }
    }
}
