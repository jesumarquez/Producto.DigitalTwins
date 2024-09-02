using Producto.DigitalTwins.DanielliContract;

namespace Producto.DigitalTwins.ModeloDanielli
{
    public interface IAdaptadorModeloDanielli
    {
        BatchesResultado Batches(DanielliSenalesModelo[] senales);
    }
}
