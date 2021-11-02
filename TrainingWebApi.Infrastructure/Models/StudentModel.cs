using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingWebApi.Infrastructure.Models
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
