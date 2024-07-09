using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Eugene_de_Mazenod
{
    public class CAlumno
    {
        string nombre;
        float nota ;

        public CAlumno()
        {
            this.nombre ="undefined";
            this.nota = 0;
        }
        public CAlumno(string nombre,float nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        public float getNota()
        {
            return nota;
        }
        public string getNombre()
        {
                return nombre;
        }


        public override string ToString()
        {
            string datos = "\n Nombre :" + this.nombre + "\n Nota :" + this.nota.ToString();

            return datos;
        }

        
    }
}
