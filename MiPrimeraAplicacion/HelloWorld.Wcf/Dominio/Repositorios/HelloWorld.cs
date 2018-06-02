using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Wcf.Dominio.Repositorios
{
    public class HelloWorld
    {
        public IList<string> ObtenerListaDePalabrasProhibidas ()
        {
            IList<string> laLista = new List<string>();
            laLista.Add("sorry");
            laLista.Add("pepino");
            laLista.Add("payaso");
            laLista.Add("sorbeto");
            return laLista;
        }
    }
}