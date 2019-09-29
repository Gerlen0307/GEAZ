using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Usuario
    {
        List<D_Persona> lista = new List<D_Persona>();
        public void Guardar(D_Persona Persona)
        {
            lista.Add(Persona);


        }
        public List<D_Persona> Consultar()
        {
            return lista;
        }

    }
}
