using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    class Alumno:Persona//la clase que herede de la clase abstracta. Alumno esta obligado a implementar los metodos abstractos de Persona.
    {
        public string legajo;

        public Alumno(string DNI, string Legajo, string Nombre):base(DNI)
        {
            this.legajo = Legajo;
            this.Nombre = Nombre;
        }

        public override void Mostrar()
        {
            Console.WriteLine("\nLegajo: " + this.legajo);
            Console.WriteLine("Nombre: " + this._nombre);
            Console.WriteLine("DNI: " + this.dni);
        }

        public override string Nombre
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public virtual void OtroVirtual()
        { }
    }
}
