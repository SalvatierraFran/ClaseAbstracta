using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    public abstract class Persona:SerHumano//A la clase abstracta no la puedo instanciar
    {
        public string dni;
        protected string _nombre;

        public abstract string Nombre//Propiedad abstracta
        {
            get;
            set;
        }

        public Persona(string DNI)
        {
            this.dni = DNI;
        }

        public abstract void Mostrar();//Metodo abstracto (dentro de la clase abstracta). Lo mas importante es la firma.

        public void MostrarDNI()
        {
            Console.WriteLine(this.dni);
        }

        public override void MostrarFecha()
        {
            Console.WriteLine(this.fechaNac);
            //throw new NotImplementedException();
        }

        public override void AlgoVirtual()
        {
            base.AlgoVirtual();
        }

        
    }
}
