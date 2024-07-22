using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.ColadaCases.Common;
using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;
using Producto.DigitalTwins.Domain.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Application.ColadaCases.Commands.Crear
{
    public class CrearColadaCommandHandler : IRequestHandler<CrearColadaCommand, ErrorOr<ColadaCreadaResult>>
    {
        private readonly IColadaRepository _coladaRepository;

        public CrearColadaCommandHandler(IColadaRepository coladaRepository)
        {
            _coladaRepository = coladaRepository;
        }

        public async Task<ErrorOr<ColadaCreadaResult>> Handle(CrearColadaCommand request, CancellationToken cancellationToken)
        {
            if (_coladaRepository.GetByNumeroColada(request.Numero) is not null)
            {
                return Errors.Colada.ColadaDuplicada;
            }

            var nuevaColada = new Colada()
            {
                Numero = request.Numero
            };

            _coladaRepository.Add(nuevaColada);

            return new ColadaCreadaResult(nuevaColada.Id, nuevaColada.Numero, nuevaColada.FechaCreacion);
        }
    }
}
