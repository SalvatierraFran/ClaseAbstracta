using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona UnaPersona = new Persona(); Los objetos de las clases abstractas no se pueden instanciar. Pero, todas las
            instanciasde las clases que heredan de la abstracta pueden tomarse como instancia de la clase abstracta*/

            List<Persona> ListaDePersonas = new List<Persona>();

            Alumno unAlumno = new Alumno("37710555", "11111", "Franco");
            AlumnoEgresado Alumnito = new AlumnoEgresado("37150087", "222222", "Lala", 1993);

            ListaDePersonas.Add(unAlumno);
            ListaDePersonas.Add(Alumnito);

            foreach (Persona item in ListaDePersonas)
            {
                item.Mostrar();
            }
            /*1- Los metodos abstractos solo estan en clases abstractas.
             2- Los metodos abstractos no tienen implementacion*/

            Console.ReadKey();

            /*Hacer ejercicio 44 y 51. Luego de hacer estos dos, empezar con Centralita.*/

            /*Parciales como 58, 59, 61*/
        }
    }
}
