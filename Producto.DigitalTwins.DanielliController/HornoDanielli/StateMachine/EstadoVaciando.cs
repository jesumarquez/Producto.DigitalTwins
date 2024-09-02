using Producto.DigitalTwins.DanielliContract;
using System.Collections.Generic;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine
{
    internal class EstadoVaciando : IEstadoHorno
    {
        public void ProcesarSenales(IContextoHorno contextoHorno, SortedSet<DanielliSenalesModelo> senales)
        {

        }
    }
}
