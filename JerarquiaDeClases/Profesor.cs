using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    class Profesor:Persona
    {
        public Profesor(string nombre, string DNI):base(DNI)
        { }

        public override string Nombre
        {
            get
            {
                return this._nombre;
                //throw new NotImplementedException();
            }
            set
            {
                this._nombre = value;
                //throw new NotImplementedException();
            }
        }

        public override void Mostrar()
        {
            Console.WriteLine("Nombre: " + this.Nombre);
            //throw new NotImplementedException();
        }
    }
}
