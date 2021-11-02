using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingWebApi.Domain.Models;
using TrainingWebApi.Infrastructure.Models;

namespace TrainingWebApi.Infrastructure.Data
{
    public class StudentsDbContex: DbContext
    {
        public StudentsDbContex(DbContextOptions<StudentsDbContex> options) : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
