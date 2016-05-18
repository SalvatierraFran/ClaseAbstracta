using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClases
{
    public abstract class SerHumano
    {
        public DateTime fechaNac;

        public abstract void MostrarFecha();

        //Las clases abstractas obligan a las clases no abstractas a implementar los metodos abstractos.

        public virtual void AlgoVirtual()
        { }
    }
}
