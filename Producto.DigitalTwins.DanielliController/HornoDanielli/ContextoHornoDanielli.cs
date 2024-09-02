using Producto.DigitalTwins.DanielliContract;
using Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine;
using Producto.DigitalTwins.Domain.Entities;
using Producto.DigitalTwins.ModeloDanielli;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Producto.DigitalTwins.DanielliController.HornoDanielli
{
    internal class ContextoHornoDanielli : IContextoHorno
    {
        private readonly IAdaptadorModeloDanielli _adaptadorModeloDanielli;

        public IEstadoHorno Estado { get; private set; }
        public Colada Colada { get; private set; }

        public ContextoHornoDanielli(IAdaptadorModeloDanielli adaptadorModeloDanielli)
        {
            _adaptadorModeloDanielli = adaptadorModeloDanielli;
            Reset();
        }

        private void Reset()
        {
            Estado = new EstadoEnEspera();
        }

        public void ProcesarSenales(SortedSet<DanielliSenalesModelo> senales)
        {
            Estado.ProcesarSenales(this, senales);
        }

        public void IniciarColada(Colada nuevaColada)
        {
            Colada = nuevaColada;
            ColadaIniciada();
        }

        private void ColadaIniciada()
        {
            throw new NotImplementedException();
        }

        public void FinalizarColada()
        {
            ColadaFinalizada();
        }

        private void ColadaFinalizada()
        {
            throw new NotImplementedException();
        }

        public void CambiarEstado(IEstadoHorno nuevoEstado)
        {
            if(!nuevoEstado.GetType().Equals(Estado.GetType()))
            {
                Estado = nuevoEstado;
                CambioDeEstado();
            }
        }

        private void CambioDeEstado()
        {
            throw new NotImplementedException();
        }

        public void GuardarSenales()
        {
            throw new System.NotImplementedException();
        }

        public void EjecutarModelo(SortedSet<DanielliSenalesModelo> senales)
        {
            BatchesResultado batchesResultado = _adaptadorModeloDanielli.Batches(senales.ToArray());
            GuardarSalidasModelo(batchesResultado);
        }

        private void GuardarSalidasModelo(BatchesResultado batchesResultado)
        {
            throw new NotImplementedException();
        }

        public IEstadoHorno DeterminarEstado(SortedSet<DanielliSenalesModelo> senales)
        {
            throw new NotImplementedException();
        }

        public bool EstaFundiendo(SortedSet<DanielliSenalesModelo> senales)
        {
            throw new NotImplementedException();
        }

        public bool EstaVaciando(SortedSet<DanielliSenalesModelo> senales)
        {
            throw new NotImplementedException();
        }
    }
}
