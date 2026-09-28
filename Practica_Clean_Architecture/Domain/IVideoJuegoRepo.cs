using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   
        public interface IVideoJuegoRepo
        {
            IEnumerable<VideoJuego> Getall();
            void create (VideoJuego videoJuego);
            void update(VideoJuego videoJuego);
            void delete(VideoJuego videoJuego);
        }
    
}
