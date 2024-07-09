using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace College_Eugene_de_Mazenod
{
    public class CEscuela
    {
        ArrayList listaDeAlumnos;

        public CEscuela()
        {
            listaDeAlumnos=new ArrayList();
        }

        public CAlumno BuscarAlumno(string nombre)
        {
            foreach(CAlumno c in listaDeAlumnos)
            {
                if(c.getNombre()== nombre)
                {
                    return c;
                }
            }
            return null;
        }
        public bool AgregarAlumno(CAlumno alumno)
        {
            CAlumno aux=BuscarAlumno(alumno.getNombre());

            if (aux == null)
            {
                listaDeAlumnos.Add(alumno);
            }

            return false;
        }

        public int getCAndidadDeAlumnos()
        {
            return listaDeAlumnos.Count;
        }
        public float getSumaDeNotas()
        {
            float suma = 0;
            foreach(CAlumno c in listaDeAlumnos)
            {
                suma += c.getNota();
            }
            return suma;
        }

        public float PromedioAlumnos()
        {
            return getSumaDeNotas()/getCAndidadDeAlumnos();
        }

        public CAlumno MejorEstudiante()
        {
            CAlumno MejorAlumno=new CAlumno();
            foreach (CAlumno al in listaDeAlumnos)
            {
                if(al.getNota()> MejorAlumno.getNota())
                {
                    MejorAlumno=al;
                }
            }
            return MejorAlumno;
        }
        public string ListaDeAlumnos()
        {
            string datos = " ********         ALUMNOS       *******************";
            foreach(CAlumno c in listaDeAlumnos)
            {
                datos += c.ToString();
            }
            return datos;
        }
    }
}
