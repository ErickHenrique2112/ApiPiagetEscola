using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPiagetEscola.Models;

namespace ApiPiagetEscola.Data
{
    public class ApiPiagetEscolaContext : DbContext
    {
        public ApiPiagetEscolaContext (DbContextOptions<ApiPiagetEscolaContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPiagetEscola.Models.Escola> Escola { get; set; } = default!;
        public DbSet<ApiPiagetEscola.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<ApiPiagetEscola.Models.Professor> Professor { get; set; } = default!;
    }
}
