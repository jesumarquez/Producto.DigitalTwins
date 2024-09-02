using Producto.DigitalTwins.DanielliContract;
using System.Collections.Generic;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine
{
    internal class EstadoCargandoChatarra : IEstadoHorno
    {
        public void ProcesarSenales(IContextoHorno contextoHorno, SortedSet<DanielliSenalesModelo> senales)
        {
            if(contextoHorno.EstaFundiendo(senales))
            {
                contextoHorno.CambiarEstado(new EstadoFundiendo());
            }
        }
    }
}
