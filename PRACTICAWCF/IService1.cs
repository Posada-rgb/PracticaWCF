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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        //             ==== EXPLICACIÓN RECONOCIMIENTO DE METODOS ====

            //Aqui solamente se mandan a llamar los metodos que se crearon 

        [OperationContract]
        public Peliculas Registrar();

        [OperationContract]
        public Peliculas ver(Peliculas pelicula);

        [OperationContract]
        public string _3ermetodo();

        // TODO: agregue aquí sus operaciones de servicio
    }


}
