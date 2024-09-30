using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ClubDeportivo
    {
        private List<Socio> socios = new List<Socio>();
        private List<ActividadDeportiva> actividades = new List<ActividadDeportiva>();

        public string AltaSocio(string nombre, int id)
        {
            if (!socios.Any(s => s.NumeroIdentificacion == id))
            {
                socios.Add(new Socio(nombre, id));
                return "REGISTRO DE SOCIO EXITOSO";
            } else
            {
                return "EL SOCIO YA SE ENCUENTRA REGISTRADO";  
            }
        }

        public string AltaActividad(string nombre, int cupoTotal)
        {
            if (!this.actividades.Any(s => s.Nombre == nombre))
            {
                this.actividades.Add(new ActividadDeportiva(nombre, cupoTotal));
                return "REGISTRO DE ACTIVIDAD EXITOSO";
            } else
            {
                return "LA ACTIVIDAD YA SE ENCUENTRA REGISTRADA";
            }

        }

        public string InscribirSocioEnActividad(int id, string nombreActividad)
        {
            var socio = this.socios.FirstOrDefault(s => s.NumeroIdentificacion == id);
            var actividad = this.actividades.FirstOrDefault(a => a.Nombre == nombreActividad);

            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            if (!socio.TieneCupo())
            {
                return "TOPE DE ACTIVIDADES POR SOCIO ALCANZADO";
            } else if (!actividad.TieneCupo())
            {
                return "CUPO DE LA ACTIVIDAD AGOTADO";  
            } else

            {
                socio.AgregarActividad(actividad);
                actividad.ActualizarCupo();
                return "INSCRIPCIÓN EXITOSA";
            }
        }
    }
}
