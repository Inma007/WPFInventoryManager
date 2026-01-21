using Castle.Core.Logging;
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
    public class DepartamentoRepository: GenericRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(DiinventarioexamenContext context,ILogger<GenericRepository<Departamento>>logger)
            :base(context,logger)
        {

        }
    }
}
