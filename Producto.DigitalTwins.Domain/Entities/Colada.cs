﻿using Producto.DigitalTwins.Domain.Primivites;

namespace Producto.DigitalTwins.Domain.Entities
{
    public sealed class Colada : Entity
    {
        internal Colada(Guid id, int numero) : base(id)
        {
            Numero = numero;
            FechaCreacion = DateTime.UtcNow;
        }

        public int Numero { get; private set; }

        public DateTime FechaCreacion { get; private set; }

        public static Colada CrearColada(int numero)
        {
            var colada = new Colada(Guid.NewGuid(), numero);

            return colada;
        }
    }
}
