using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ActividadDeportiva
    {
        public string Nombre { get; private set; }
        public int CuposDisponibles { get; private set; }

        public ActividadDeportiva(string nombre, int cupoTotal)
        {
            Nombre = nombre;
            CuposDisponibles = cupoTotal;
        }

        public void ActualizarCupo()
        {
            if (TieneCupo())
            {
                CuposDisponibles--;
            }
        }

        public bool TieneCupo()
        {
            return CuposDisponibles > 0;
        }
    }
}