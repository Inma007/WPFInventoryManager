using di.WPFInventoryManager.Backend.Modelos;
using di.WPFInventoryManager.Backend.Servicios;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.WPFInventoryManager.Backend.Servicios_Repositorio_
{
    public class TipoUsuarioRepository : GenericRepository<Tipousuario>, ITipoUsuarioRepository
    {
        public TipoUsuarioRepository(DiinventarioexamenContext context, ILogger<GenericRepository<Tipousuario>> logger)
            : base(context, logger)
        {

        }
    }
}
