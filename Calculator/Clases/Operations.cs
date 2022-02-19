using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operations
{
    public class Operations : ICalculator
    {
        public double division(double cantidad1, double cantidad2)
        {
            return cantidad1 / cantidad2;
        }

        public double multiplicacion(double cantidad1, double cantidad2)
        {
            return cantidad1 * cantidad2;
        }

        public double resta(double cantidad1, double cantidad2)
        {
            return cantidad1 - cantidad2;
        }

        public double suma(double cantidad1, double cantidad2)
        {
            return cantidad1 + cantidad2;
        }
    }
}
