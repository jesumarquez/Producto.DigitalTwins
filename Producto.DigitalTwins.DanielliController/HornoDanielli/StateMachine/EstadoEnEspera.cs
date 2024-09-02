using Producto.DigitalTwins.DanielliContract;
using Producto.DigitalTwins.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine
{
    internal class EstadoEnEspera : IEstadoHorno
    {
        public void ProcesarSenales(IContextoHorno contextoHorno, SortedSet<DanielliSenalesModelo> senales)
        {
            int numeroColada = senales.First().NumeroColada;

            var colada = Colada.CrearColada(numeroColada);

            contextoHorno.IniciarColada(colada);
            contextoHorno.CambiarEstado(new EstadoCargandoChatarra());
        }
    }
}
