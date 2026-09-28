using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Infraestructura
{
    public class VideoJuegoRepo : IVideoJuegoRepo
    {
        public static readonly List<VideoJuego> _videojuego_repo = new List<VideoJuego>() ;

        public void create(VideoJuego videoJuego)
        {
           _videojuego_repo.Add(videoJuego);
        }


        public void delete(VideoJuego videoJuego)
        {
            _videojuego_repo.Remove(videoJuego);
        }

        public IEnumerable<VideoJuego> Getall()
        {
            return _videojuego_repo;
        }

        public void update(VideoJuego videoJuego)
        {
            // 2. Buscamos el juego existente por su ID en la lista
            int indice = _videojuego_repo.FindIndex(v => v.id == videoJuego.id);
            // Si lo encuentra, reemplaza el objeto viejo por el nuevo
            if (indice != -1)
            {
                _videojuego_repo[indice] = videoJuego;
            }

        }
    }
}
