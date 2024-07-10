namespace College_Eugene_de_Mazenod
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char Opcion;
            CEscuela Mazenod = new CEscuela();

            do
            {
                Opcion = Convert.ToChar(CInterfaz.DarOpcion());
                Opcion = char.ToUpper(Opcion);

                switch (Opcion)
                {
                    case 'A':
                        string nombre = CInterfaz.PedirDato("Nombre");
                        float nota= (float)Convert.ToDouble(CInterfaz.PedirDato("Nota"));
                        CAlumno Al= new CAlumno(nombre,nota);
                        Mazenod.AgregarAlumno(Al);
                        break;
                    case 'B':
                        Console.WriteLine("\nLA LISTA DE LOS ESTUDIANTE ES :\n");
                        Console.WriteLine(Mazenod.ListaDeAlumnos());

                        Console.ReadKey();
                        break;
                    case 'C':
                        Console.WriteLine("Cantidad de Estudiante Ingresado :");
                        Console.WriteLine(Mazenod.getCAndidadDeAlumnos());
                        
                        break;
                    case 'D':
                        Console.WriteLine(Mazenod.MejorEstudiante().ToString());
                        break;
                     case 'E':
                        Console.WriteLine("\n PROMEDIO GENERAL DE LA CLASE \n");
                        Console.WriteLine(Mazenod.PromedioAlumnos());
                        break;
                    case 'F':
                        Console.WriteLine("\n LA LISTA DE LOS ESTUDIANTE \n");
                        Console.WriteLine(Mazenod.ListaDeAlumnosOrdenado());
                        break;
                }

            } while (Opcion !='S');
        }
    }
}
