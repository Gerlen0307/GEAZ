using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Mantenimiento
    {
        List<N_Producto>  lista   = new List<N_Producto>();

        public void Guardar(N_Producto productos){
            lista.Add(productos);


        }
        public List<N_Producto> Consultar()
        {
            return lista;
        }

    }
}

    
