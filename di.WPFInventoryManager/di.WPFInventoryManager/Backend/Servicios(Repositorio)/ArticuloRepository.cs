using Castle.Core.Logging;
using di.WPFInventoryManager.Backend.Modelos;
using di.WPFInventoryManager.Backend.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di.WPFInventoryManager.Backend.Servicios_Repositorio_
{
    public class ArticuloRepository: GenericRepository<Articulo>, IArticuloRepository
    {
        public ArticuloRepository(DiinventarioexamenContext context,ILogger<GenericRepository<Articulo>> logger)
        :base(context,logger)
        { }

        public async Task<int?> GetUltimoIdAsync()
        {
            return await _dbSet.MaxAsync(a => (int?)a.Idarticulo);
        }

    }
}
