using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones_C_Sharp
{
    public class Personas
    {
        public string Nombre { get; set; }
        public DateTime? Fecha = null;
        public int Id { get; set; }
        public Personas? _Next = null;

        public Personas( string _Nombre, DateTime _Fecha , string _Id )
        {
            Nombre = _Nombre;
            Fecha = _Fecha;
            Id = Convert.ToInt32( _Id );
        }
    }
}
