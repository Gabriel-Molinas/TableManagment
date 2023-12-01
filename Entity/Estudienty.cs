using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudienty
    {
        public int id { get; set; }
        public string Nombre { get; set; }
      

        public DateTime Fecha { get; set; }
        public float Promedio { get; set; }
        public int idCurso { get; set; }
    }
}
