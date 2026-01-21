using Castle.Core.Logging;
using di.WPFInventoryManager.Backend.Modelos;
using di.WPFInventoryManager.Backend.Servicios;
using Microsoft.Extensions.Logging;

namespace di.WPFInventoryManager.Backend.Servicios_Repositorio_
{
    public class GrupoRepository : GenericRepository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(DiinventarioexamenContext context, ILogger<GenericRepository<Grupo>> logger)
            : base(context, logger)
        {

        }
    }
}
