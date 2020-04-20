using cqrs.Domains.Commands.Responses.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cqrs.Domains.Commands.Requests.Usuario
{
    public class AutenticarUsuarioRequest : IRequest<AutenticarUsuarioResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
