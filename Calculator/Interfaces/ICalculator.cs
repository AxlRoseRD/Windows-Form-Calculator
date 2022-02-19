using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface ICalculator
    {
        double suma(double cantidad1, double cantidad2);
        double resta(double cantidad1, double cantidad2);
        double division(double cantidad1, double cantidad2);
        double multiplicacion(double cantidad1, double cantidad2);
    }
}
