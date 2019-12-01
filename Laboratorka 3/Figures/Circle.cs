﻿using System;

namespace Laboratorka_3
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Круг с радиусом {Radius} имеет площадь {Area()}";
        }
    }
}