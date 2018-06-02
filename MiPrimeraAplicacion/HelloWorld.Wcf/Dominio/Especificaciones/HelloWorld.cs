using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Wcf.Dominio.Especificaciones
{
    public class MyHelloWorld
    {


        public string SayHello()
        {
            // Acciones.MyHelloWorld laAccion = new Acciones.MyHelloWorld();
            var laAccion = new Acciones.MyHelloWorld();
            var elResultado = laAccion.SayHello();
            return elResultado;
        }

        public string SayMessageToSomebody(string message, string name)
        {
            // Acciones.MyHelloWorld laAccion = new Acciones.MyHelloWorld();
            var laAccion = new Acciones.MyHelloWorld();
            string elResultado = laAccion.SayMessageToSomebody(message, name);
            return elResultado;
        }
    }
}