using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class VideoJuegoService
    {

        private readonly IVideoJuegoRepo _repo;

        public VideoJuegoService(IVideoJuegoRepo repo)
        { _repo = repo; }

        public void crearvideojuego(VideoJuego videoJuego) 
        {
            videoJuego.id = Guid.NewGuid();
            _repo.create(videoJuego);
        }

        public IEnumerable<VideoJuego> ObtenerTodos()
        {
           return _repo.Getall();
        } 

       public void update(VideoJuego videoJuego)
        {  _repo.update(videoJuego);}


    }
}
