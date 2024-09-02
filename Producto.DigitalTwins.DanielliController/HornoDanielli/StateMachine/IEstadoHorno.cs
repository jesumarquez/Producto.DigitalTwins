namespace Producto.DigitalTwins.DanielliController.HornoDanielli.StateMachine
{
    internal interface IEstadoHorno
    {
        void ProcesarSenales(IContextoHorno contextoHorno, System.Collections.Generic.SortedSet<DanielliContract.DanielliSenalesModelo> senales);
    }
}
