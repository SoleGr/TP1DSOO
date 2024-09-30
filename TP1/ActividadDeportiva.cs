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
        private int cupoTotal;
        public int CuposDisponibles { get; private set; }

        public ActividadDeportiva(string nombre, int cupoTotal)
        {
            Nombre = nombre;
            this.cupoTotal = cupoTotal;
            CuposDisponibles = cupoTotal;
        }

        public void ActualizarCupo()
        {
                this.CuposDisponibles--;
        }

        public bool TieneCupo()
        {
            return CuposDisponibles > 0;
        }
    }
}