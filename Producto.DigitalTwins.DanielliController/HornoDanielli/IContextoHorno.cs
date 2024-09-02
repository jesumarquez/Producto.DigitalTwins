using Producto.DigitalTwins.DanielliContract;
using Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine;
using System.Collections.Generic;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli
{
    internal interface IContextoHorno
    {
        void IniciarColada(Domain.Entities.Colada colada);
        void FinalizarColada();
        void CambiarEstado(IEstadoHorno nuevoEstado);
        void GuardarSenales();
        void EjecutarModelo(SortedSet<DanielliSenalesModelo> senales);
        void ProcesarSenales(SortedSet<DanielliSenalesModelo> _senales);
        IEstadoHorno DeterminarEstado(SortedSet<DanielliSenalesModelo> senales);
        bool EstaFundiendo(SortedSet<DanielliSenalesModelo> senales);
        bool EstaVaciando(SortedSet<DanielliSenalesModelo> senales);
    }
}
