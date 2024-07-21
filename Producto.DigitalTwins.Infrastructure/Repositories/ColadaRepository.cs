﻿using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Infrastructure.Repositories
{
    public class ColadaRepository : IColadaRepository
    {
        private static List<Colada> _coladaList = new List<Colada>();

        public void Add(Colada colada)
        {
            _coladaList.Add(colada);
        }

        public Colada? GetByNumeroColada(int numeroColada)
        {
            return _coladaList.SingleOrDefault(c => c.Numero == numeroColada);
        }
    }
}
