using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Socio(string nombre, int numeroIdentificacion)
    {
        public string Nombre { get; private set; } = nombre;
        public int NumeroIdentificacion { get; private set; } = numeroIdentificacion;
        public List<ActividadDeportiva> Actividades { get; } = new List<ActividadDeportiva>();

        public bool TieneCupo()
        {
            return !(Actividades.Count >= 3);
        }

        public void AgregarActividad(ActividadDeportiva actividad)
        {
            Actividades.Add(actividad);
        }
    }
}
