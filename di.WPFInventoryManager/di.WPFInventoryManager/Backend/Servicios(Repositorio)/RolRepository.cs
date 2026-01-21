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
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        public RolRepository(DiinventarioexamenContext context, ILogger<GenericRepository<Rol>> logger)
            : base(context, logger)
        {

        }
    }
}
