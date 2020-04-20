using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cqrs.Domains.Commands.Responses.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public bool RetornoStatus { get; set; } 
        public DateTime RequestTime
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
