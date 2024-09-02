using Producto.DigitalTwins.Common.Controllers;
using Producto.DigitalTwins.DanielliContract;
using Producto.DigitalTwins.DanielliController.HornoDanielli;
using System.Collections.Generic;

namespace Producto.DigitalTwins.DanielliController.Controllers
{
    public interface IDanielliModelController : IModelController { }

    internal class DanielliModelController : BaseModelController, IDanielliModelController
    {
        private readonly IContextoHorno _contextoHornoDanielli;
        private SortedSet<DanielliSenalesModelo> _senales;

        public DanielliModelController(IContextoHorno contextoHornoDanielli)
        {
            _contextoHornoDanielli = contextoHornoDanielli;
        }

        protected override void DoWork()
        {
            _contextoHornoDanielli.ProcesarSenales(_senales);
        }
    }
}
