﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingWebApi.Domain.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
