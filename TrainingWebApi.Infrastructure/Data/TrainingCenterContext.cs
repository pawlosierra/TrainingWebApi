using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Infrastructure.Models;

namespace TrainingWebApi.Infrastructure.Data
{
    public class TrainingCenterContext : DbContext
    {
        public TrainingCenterContext(DbContextOptions<TrainingCenterContext> options) : base(options)
        {
        }

        public DbSet<Countries> Countries { get; set; }
        public DbSet<VisaRequirementModel> visaRequirementModel { get; set; }
        
    }
}
