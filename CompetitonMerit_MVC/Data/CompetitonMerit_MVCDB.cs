using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompetitonMerit_MVC.Models;

namespace CompetitonMerit_MVC.Data
{
    public class CompetitonMerit_MVCDB : DbContext
    {
        public CompetitonMerit_MVCDB (DbContextOptions<CompetitonMerit_MVCDB> options)
            : base(options)
        {
        }

        public DbSet<CompetitonMerit_MVC.Models.School> School { get; set; }

        public DbSet<CompetitonMerit_MVC.Models.Subject> Subject { get; set; }

        public DbSet<CompetitonMerit_MVC.Models.Student_participate> Student_participate { get; set; }

        public DbSet<CompetitonMerit_MVC.Models.Meritlist> Meritlist { get; set; }
    }
}
