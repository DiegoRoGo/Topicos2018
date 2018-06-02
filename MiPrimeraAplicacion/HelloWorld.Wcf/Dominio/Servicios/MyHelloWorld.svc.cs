using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HelloWorld.Wcf.Dominio.Interfaces;

namespace HelloWorld.Wcf.Dominio.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MyHelloWorld : Interfaces.IHelloWorld
    {
        public string SayMessageToSomebody(string message, string name)
        {
            var laEspecificacion = new Dominio.Especificaciones.MyHelloWorld();
            string elResultado = laEspecificacion.SayMessageToSomebody(message, name);
            return elResultado;
        }


        public string SayMessage(string message)
        {
            throw new NotImplementedException();
        }


        public string SayHelloToSomebody(string name)
        {
            throw new NotImplementedException();
        }

        public string SayHello()
        {
            var laEspecificacion = new Dominio.Especificaciones.MyHelloWorld();
            var elResultado = laEspecificacion.SayHello();
            return elResultado;
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public MyCompositeType GetDataUsingDataContract(MyCompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
