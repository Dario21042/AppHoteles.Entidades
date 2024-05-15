using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppHoteles.Entidades;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<AppHoteles.Entidades.Hotel> Hotel { get; set; } = default!;

        public DbSet<AppHoteles.Entidades.Reserva> Reserva { get; set; } = default!;
    }
