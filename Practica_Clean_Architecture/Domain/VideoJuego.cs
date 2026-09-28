using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class VideoJuego
    {

        public string nombre { get; set; }
        public Guid id { get; set; } = Guid.NewGuid();
        public string genero { get; set; }
        public int anio_salida { get; set; }

        public float precio { get; set; }
    }
}
