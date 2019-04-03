using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GUI.lab19.Models
{
    public class ApplicantDbContext:DbContext
    {
        public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options)
            :base(options)
        {}

        public DbSet<Applicant> Products { get; set; }
    }
}
