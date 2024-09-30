using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Socio
    {
        public string Nombre { get; private set; }
        public int NumeroIdentificacion { get; private set; }
        public List<ActividadDeportiva> Actividades { get; } = new();

        public Socio(string nombre, int numeroIdentificacion)
        {
            Nombre = nombre;
            NumeroIdentificacion = numeroIdentificacion;
        }

        public bool TieneCupo()
        {
            return Actividades.Count < 4;
        }

        public void AgregarActividad(ActividadDeportiva actividad)
        {
            Actividades.Add(actividad);
        }

    }
}
