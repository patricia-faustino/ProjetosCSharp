using System;
using ExHerInteracao.Model.Enums;

namespace ExHerInteracao.Model.Entities
{
   abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
       
    }
}
