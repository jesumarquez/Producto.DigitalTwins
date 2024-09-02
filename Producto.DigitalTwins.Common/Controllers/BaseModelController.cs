namespace Producto.DigitalTwins.Common.Controllers
{
    public abstract class BaseModelController : IModelController
    {
        public void Start()
        {
            DoWork();
        }

        protected abstract void DoWork();
    }
}
