using Producto.DigitalTwins.DanielliContract;
using System.Collections.Generic;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine
{
    internal class EstadoFundiendo : IEstadoHorno
    {
        public void ProcesarSenales(IContextoHorno contextoHorno, SortedSet<DanielliSenalesModelo> senales)
        {
            if(contextoHorno.EstaVaciando(senales))
            {
                contextoHorno.CambiarEstado(new EstadoVaciando());
            }
        }
    }
}
