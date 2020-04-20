using cqrs.Domains.Commands.Requests.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cqrs.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(
                [FromServices]IMediator mediator,
                [FromBody]AutenticarUsuarioRequest req
            )
        {
            var res = mediator.Send(req);
            return Ok(res);
        }
    }
}
