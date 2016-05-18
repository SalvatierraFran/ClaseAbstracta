using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    class AlumnoEgresado:Alumno
    {
        public int añoDeEgreso;

        public AlumnoEgresado(string DNI, string Legajo, string Nombre, int AñoDeEgreso):base(DNI, Legajo, Nombre)
        {
            this.añoDeEgreso = AñoDeEgreso;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Año de egresado: " + this.añoDeEgreso);
        }

        public override void OtroVirtual()
        {
            base.OtroVirtual();
        }
    }
}
