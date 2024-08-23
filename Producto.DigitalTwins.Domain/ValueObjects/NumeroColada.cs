using ErrorOr;
using Producto.DigitalTwins.Domain.Errors;
using Producto.DigitalTwins.Domain.Primivites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Domain.ValueObjects
{
    public sealed class NumeroColada : ValueObject
    {
        private readonly static int MIN_NUMERO_COLDA = 10000;

        public int Value { get; }

        private NumeroColada(int numero) 
        {
            Value = numero;
        }

        public static ErrorOr<NumeroColada> Crear(int numero)
        {
            if(numero < MIN_NUMERO_COLDA)
            {
                return Error.Validation(code: "NumeroColada.Invalido", description: "Numero de colada invalido.");
            }

            var numeroColada = new NumeroColada(numero);

            return numeroColada;
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
