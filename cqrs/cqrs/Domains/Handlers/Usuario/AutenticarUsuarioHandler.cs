using cqrs.Domains.Commands.Requests.Usuario;
using cqrs.Domains.Commands.Responses.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace cqrs.Domains.Handlers.Usuario
{
    public class AutenticarUsuarioHandler : IRequestHandler<AutenticarUsuarioRequest, AutenticarUsuarioResponse>
    {
        public Task<AutenticarUsuarioResponse> Handle(AutenticarUsuarioRequest request, CancellationToken cancellationToken)
        {
            // Realiza N lógicas.

            var res = new AutenticarUsuarioResponse()
            {
                RetornoStatus = true
            };

            return Task.FromResult(res);
        }
    }
}
