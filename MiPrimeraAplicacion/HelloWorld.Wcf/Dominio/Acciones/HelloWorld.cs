using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace HelloWorld.Wcf.Dominio.Acciones
{
    public class MyHelloWorld
    {
        public string SayHello()
        {
            return "Hello world";
        }

        internal string SayMessageToSomebody(string message, string name)
        {
            if (new Validaciones.HelloWorld().ElMensajeTienePalabrasNoPermitidas(message))
            {
                message = ReplaceBadWords(message);
            }
            return BuildMessage(message, name);
        }
        string ReplaceBadWords(string sentence)
        {
            string[] palabrasOracion = sentence.Split(' ');
            IList<string> palabrasProhibidas = new Repositorios.HelloWorld().ObtenerListaDePalabrasProhibidas();

            for (int i = 0; i < palabrasOracion.Length; i++)
                for (int j = 0; j < palabrasProhibidas.Count; j++)
                    if (palabrasOracion[i].Equals(palabrasProhibidas[j]))
                    {
                        palabrasOracion[i] = Regex.Replace(palabrasOracion[i], @"(?<!^)\w(?!$)", "*");
                        break;
                    }
            return string.Join(" ", palabrasOracion);
        }
        string BuildMessage(string message, string name)
        {
            return $"{message}, {name}";
        }
    }
}