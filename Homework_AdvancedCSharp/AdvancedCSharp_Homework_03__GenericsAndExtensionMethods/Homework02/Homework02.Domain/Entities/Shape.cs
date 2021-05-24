﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Entities
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
