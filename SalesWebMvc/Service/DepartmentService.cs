using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Service
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Mudado de Sincrona para Assincrona.
        public async Task<List<Department>> FindAllAsync()
        {
            // O "await" diz que é uma chamada assincrona.
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }

    


}
