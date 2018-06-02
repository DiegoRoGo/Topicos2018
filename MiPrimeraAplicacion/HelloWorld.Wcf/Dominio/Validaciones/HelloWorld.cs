using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Wcf.Dominio.Validaciones
{
    public class HelloWorld
    {
        public bool LaPalabraEstaPermitida (string laPalabra, IList<string> laLista)
        {
            return laLista.Contains(laPalabra);
        }

        public bool ElMensajeTienePalabrasNoPermitidas(string pOracion)
        {
            IList<string> ListaDePalabras = new Repositorios.HelloWorld().ObtenerListaDePalabrasProhibidas();
            for (int i = 0; i < ListaDePalabras.Count; i++)
                if (pOracion.Contains(ListaDePalabras[i]))
                    return true;
            return false;
        }
    }
}